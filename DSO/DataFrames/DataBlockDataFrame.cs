﻿using DSO.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSO.DataFrames
{
    public class DataBlockDataFrame : DataFrame
    {
        public DataBlockDataFrame(byte[] data) : base(data, 192, 50)
        {
            if (FrameID != 192 || FrameSubID != 50)
            {
                throw new InvalidDataFrameException("Wrong DataBlockDataFrame - invalid FrameID");
            }
            else if (this.Data.Count() < 128)
            {
                throw new InvalidDataFrameException("Wrong DataBlockDataFrame - not enough data");
            }
        }
    }
}
