// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright � 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace QR_SCU_Emulator
{
    [DefaultPropertyAttribute("none")]
    public class Series  
    {
        private string seriesUid;
        public ArrayList imageList = null;

        public Series() 
        {
            imageList = new ArrayList();
        }

        [ReadOnlyAttribute(true), CategoryAttribute("Serie Instance UID"),
        DescriptionAttribute("Identification of the UID")]
        public String SeriesUID
        {
            get 
            {
                return seriesUid;
            }
            set
            {
                seriesUid = value;
            }
        }

        public int ImageExists(string imageTitle) 
        {
            int imageExists = -1;

            for (int i = 0; i < imageList.Count; i++) 
            {
                if (((Image)imageList[i]).SOPInstanceUID == imageTitle) 
                {
                    imageExists = i;
                    break;
                }
            }
            return imageExists;
        }
    }
}
