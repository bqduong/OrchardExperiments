﻿using Orchard.ContentManagement.Records;
using System;

namespace Magelia.WebStore.Models.Records
{
    public class UserOrdersPartRecord : ContentPartRecord
    {
        public virtual Boolean EnableSorting { get; set; }
        public virtual Boolean EnablePaging { get; set; }
        public virtual Nullable<Int32> PageSize { get; set; }
    }
}