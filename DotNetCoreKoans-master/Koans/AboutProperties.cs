﻿using System;
using Xunit;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class AboutProperties : Koan
    {
        class ClassWithGet
        {
            public ClassWithGet()
            {
                a = 1;
            }
            private int a;
            public int A
            {
                get { return a; }
            }
        }
        [Step(1)]
        public void ClassesCanHaveGetters()
        {
            // Classes can can have properties with just a getter.
            ClassWithGet obj = new ClassWithGet();

            // This class only has a get for A, so this would be illegal:
            //obj.A = 5;
            Assert.Equal(1, obj.A);
        }

        class ClassWithGetSet
        {
            public ClassWithGetSet()
            {
                a = 1;
            }
            private int a;
            public int A
            {
                get { return a; }
                set { a = value; }
            }
        }
        [Step(2)]
        public void ClassesCanHaveGettersAndSetters()
        {
            // Classes can can have properties with both getters and setters.
            ClassWithGetSet obj = new ClassWithGetSet();

            // This class has a get and set for A, so you can do this:
            obj.A = 5;
            Assert.Equal(5, obj.A);
        }

        class ClassWithDefaultGetSet
        {
            public ClassWithDefaultGetSet()
            {
                A = 2;
            }
            public int A
            {
                get;
                set;
            }
        }
        [Step(3)]
        public void ClassesCanHaveDefaultGettersAndSetters()
        {
            // Classes can also have properties with default getters and setters,
            // where you don't need to supply a body if they just set and return a field
            // you neither have to declare a field for it.
            ClassWithDefaultGetSet obj = new ClassWithDefaultGetSet();

            obj.A = 5;
            Assert.Equal(5, obj.A);
        }

        class ClassWithPublicGetAndPrivateSet
        {
            public ClassWithPublicGetAndPrivateSet()
            {
                Side = 0;
                Area = 0;
            }
            private int side;
            public int Side
            {
                get
                {
                    return side;
                }
                set
                {
                    side = value;
                    Area = side * side;
                }
            }
            public int Area
            {
                get;
                private set;
            }
        }
        [Step(4)]
        public void ClassesCanHavePublicGettersWithPrivateSetters()
        {
            // It is possible to have a property with a public getter and a private setter,
            // so a user of the class can get the value but not set it, although methods of
            // the class can set it.
            // The property declaration has to be public, while the setter is declared private.
            ClassWithPublicGetAndPrivateSet obj = new ClassWithPublicGetAndPrivateSet();

            // So this would be illegal:
            // obj.Area = 20;

            obj.Side = 5;
            Assert.Equal(5, obj.Side);
            Assert.Equal(25, obj.Area);
        }

        class ClassWithIndexer
        {
            private int[] arr;
            public ClassWithIndexer()
            {
                arr = new[] { 1, 2, 3 };
            }
            public int this[long index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        }

        [Step(5)]
        public void ClassesCanHaveIndexers()
        {
            // An indexer allows a class to act as an array.
            ClassWithIndexer obj = new ClassWithIndexer();

            obj[0] = 5;
            obj[1] = 7;
            Assert.Equal(5, obj[0]);
            Assert.Equal(7, obj[1]);
        }
    }
}
