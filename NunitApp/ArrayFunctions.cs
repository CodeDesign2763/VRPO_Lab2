/*
 * Лабораторная работа по дисциплине ВРПО
 * Модульное тестирование при помощи NUnit
 * 
 * (C) 2021 by Alexander Chernokrylov <CodeDesign2763@gmail.com>
 *
 * This program is free software; 
 * you can redistribute it and/or modify
 * it under the terms of the GNU General Public License version 2
 * as published by
 * the Free Software Foundation
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301, USA.
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitApp
{
    public static class ArrayFunctions
    {
        /* Этот метод будем тестировать */

        /* Определение максимума одномерного массива
         * типа int */
        public static int largest(int[] a)
        {
            int i;
            int max = 0;
            for (i = 0; i <= a.Length - 1; i++)
            {
                if (i == 0) max = a[i];
                else
                    if (a[i] > max) max = a[i];
            }
            return max;
        }
    }
}
