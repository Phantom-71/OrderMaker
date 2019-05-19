﻿/*
    OrderMaker - http://ordermaker.org
    Copyright(c) 2019 Oleg Bruev. All rights reserved.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see https://www.gnu.org/licenses/.
*/

using Mtd.OrderMaker.Web.Data;
using System.Collections.Generic;

namespace Mtd.OrderMaker.Web.DataHandler.Filter
{
    public class Incomer
    {     
        public string IdForm { get; set; }
        public string SearchText { get; set; }
        public string SearchNumber { get; set; }
        public int PageSize { get;  set; }
        public int Page { get; set; }
        public IList<MtdFormPartField> FieldForColumn { get; set; }
        public IList<MtdFilterField> FieldForFilter { get; set; }
    }
}
