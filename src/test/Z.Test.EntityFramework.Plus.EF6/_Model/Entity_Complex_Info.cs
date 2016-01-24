﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;

namespace Z.Test.EntityFramework.Plus
{
    [Serializable]
    public class Entity_Complex_Info
    {
        public int ColumnInt { get; set; }

        public Entity_Complex_Info_Info Info { get; set; }
    }
}