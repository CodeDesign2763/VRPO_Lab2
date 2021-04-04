/*
 * ������������ ������ �� ���������� ����
 * ��������� ������������ ��� ������ NUnit
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
/* ����� �������� ������ �� ������ NunitApp
 * ��. ���� �� ���. [Dependencies]/[Add Project Reference] */
using NunitApp;

namespace ArrayFunctionsTests
{
    /* ����� � ������� ��� ������ largest 
     * ������ ArrayFunctions ������� NunitApp */
    
    /* ������� NET, ������� ����� �������������
     * ����� ������� � ������� */
    [TestFixture]
    public class TestLargestMethod
    {
        /* ������� NET, ������� ����� �������������
         * ����� ������ ������� � ������ (������) */
        [Test]
        public void test123()
        {
            int[] q = new int[] { 1, 2, 3 };
            /* ���� ������� �������� �� �����������,
             * �� ���������� ��������� ������ ����������� */
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
            /* ��������, ��� ����� ������������ 
             * ������������� ���� */
            Assert.Fail();
        }
    }
}


