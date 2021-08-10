using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AForge.Controls;
using AForge.Video.DirectShow;

namespace Camera.Function
{
    public static class Functions
    {
        /// <summary>
        /// load camera device 
        /// </summary>
        /// <param name="filterInfoCollection"></param>
        /// <returns>camera device count</returns>
        public static FilterInfoCollection loadCamerasList() {
            FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return filterInfoCollection;
        }

    }
}
