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

using NUnit.Framework;
/* Нужно добавить ссылку на проект NunitApp
 * Пр. клик по вкл. [Dependencies]/[Add Project Reference] */
using NunitApp;

namespace ArrayFunctionsTests
{
    /* Класс с тестами для метода largest 
     * класса ArrayFunctions проекта NunitApp */
    
    /* Атрибут NET, который нужно устанавливать
     * перед классом с тестами */
    [TestFixture]
    public class TestLargestMethod
    {
        /* Атрибут NET, который нужно устанавливать
         * перед каждым методом с тестом (тестом) */
        [Test]
        public void test123()
        {
            int[] q = new int[] { 1, 2, 3 };
            /* Если условие проверки не выполняется,
             * то выполнение тестового метода прерывается */
            Assert.AreEqual(ArrayFunctions.largest(q), 3);
        }

        [Test]
        public void test123neg()
        {
            int[] q = new int[] { -1, -2, -3 };
            Assert.AreEqual(ArrayFunctions.largest(q), -1);
        }

        [Test]
        public void testFail()
        {
            /* Проверим, как будет отображаться 
             * невыполненный тест */
            Assert.Fail();
        }
    }
}


