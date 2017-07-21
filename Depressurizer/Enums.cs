﻿/*
    This file is part of Depressurizer.
    Original work Copyright 2011, 2012, 2013 Steve Labbe.
    Modified work Copyright 2017 Martijn Vegter.

    Depressurizer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Depressurizer is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Depressurizer.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace Depressurizer
{
    [Flags]
    public enum AppPlatforms
    {
        None = 0,
        Windows = 1,
        Mac = 1 << 1,
        Linux = 1 << 2,
        All = Windows | Mac | Linux
    }

    [Flags]
    public enum AppTypes
    {
        Application = 1,
        Demo = 1 << 1,
        DLC = 1 << 2,
        Game = 1 << 3,
        Media = 1 << 4,
        Tool = 1 << 5,
        Other = 1 << 6,
        Unknown = 1 << 7,
        InclusionNormal = Application | Game,
        InclusionUnknown = InclusionNormal | Unknown,
        InclusionAll = (1 << 8) - 1
    }
}