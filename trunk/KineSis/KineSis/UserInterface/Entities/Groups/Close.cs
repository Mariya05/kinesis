﻿/*
   Copyright 2011 Alexandru Albu - sandu.albu@gmail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace KineSis.UserInterface.Entities.Groups
{
    /// <summary>
    /// closes a chart
    /// </summary>
    class Close : Group
    {
        String Group.Name
        {
            get
            {
                return "close";
            }
        }

        /// <summary>
        /// available only if a chart is focused
        /// </summary>
        Boolean Group.IsActive
        {
            get
            {
                return UIManager.ActiveDocument != null && UIManager.ActiveDocumentChart != null;
            }
        }

        /// <summary>
        /// you can't enter this group
        /// </summary>
        /// <param name="c"></param>
        void Group.Draw(Canvas c)
        {
        }
    }
}
