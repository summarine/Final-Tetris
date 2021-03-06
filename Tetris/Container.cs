﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris
{
    public class Container
    {
        public Container(int r,int c)
        {
            map = new GridData[r,c];
        }

        public GridData[,] map;

        public void setMapping(int row,int col,Label label)
        {
            
        }
    }

    public class GridData
    {
        public void Draw(BoxShape bs)
        {
            try
            {
                label.Dispatcher.Invoke(
                                   new Action(
                                              delegate
                                              {
                                                  label.Background = BoxFactory.GetBoxImageBrush(bs);
                                              }));
            }
            catch
            { }
        }
        public Label Lbl
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }
        public BoxShape Value
        {
            set
            {
                if (value<0) return;
                this.value = value;

                Draw(this.value);
            }
            get
            {
                return this.value;
            }
        }

        private BoxShape value;
        private Label label;

    }
}
