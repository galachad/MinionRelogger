﻿/*****************************************************************************
*                                                                            *
*  MinionReloggerLib 0.x Beta  -- https://github.com/Vipeax/MinionRelogger   *
*  Copyright (C) 2013, Robert van den Boorn                                  *
*                                                                            *
*  This program is free software: you can redistribute it and/or modify      *
*   it under the terms of the GNU General Public License as published by     *
*   the Free Software Foundation, either version 3 of the License, or        *
*   (at your option) any later version.                                      *
*                                                                            *
*   This program is distributed in the hope that it will be useful,          *
*   but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*   GNU General Public License for more details.                             *
*                                                                            *
*   You should have received a copy of the GNU General Public License        *
*   along with this program.  If not, see <http://www.gnu.org/licenses/>.    *
*                                                                            *
******************************************************************************/

using MinionReloggerLib.Interfaces.Objects;

namespace MinionReloggerLib.Interfaces
{
    public interface IRelogComponentExtension
    {
        bool Check(Account account);
        bool IsReady(Account account);
        void Update(Account account);
        void PostWork(Account account);
    }
}