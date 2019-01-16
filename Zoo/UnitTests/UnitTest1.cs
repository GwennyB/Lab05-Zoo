using System;
using Xunit;
using Zoo.Classes;
using Zoo.Interfaces;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Bear_CanBeInstantiated()
        {
            Bear bear = new Bear();
            Assert.Equal("bear", bear.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Dolphin_CanBeInstantiated()
        {
            Dolphin dolphin = new Dolphin();
            Assert.Equal("dolphin", dolphin.Species);
        }
        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Lion_CanBeInstantiated()
        {
            Lion lion = new Lion();
            Assert.Equal("lion", lion.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Narwhal_CanBeInstantiated()
        {
            Narwhal narwhal = new Narwhal();
            Assert.Equal("narwhal", narwhal.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Orca_CanBeInstantiated()
        {
            Orca orca = new Orca();
            Assert.Equal("orca", orca.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Skunk_CanBeInstantiated()
        {
            Skunk skunk = new Skunk();
            Assert.Equal("skunk", skunk.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Weasel_CanBeInstantiated()
        {
            Weasel weasel = new Weasel();
            Assert.Equal("weasel", weasel.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Wolf_CanBeInstantiated()
        {
            Wolf wolf = new Wolf();
            Assert.Equal("wolf", wolf.Species);
        }

        /// <summary>
        /// Verifies that class inherits property from base class.
        /// Property is abstract when inherited.
        /// </summary>
        [Fact]
        public void Bear_InhertsAbstractPropFromAnimal()
        {
            Bear bear = new Bear();
            Assert.False(bear.HangsWithPosse);
        }

        /// <summary>
        /// Verifies that class inherits property from base class.
        /// Property becomes concrete before inheritence.
        /// </summary>
        [Fact]
        public void Bear_InheritsConcretePropFromMammal()
        {
            Bear bear = new Bear();
            Assert.True(bear.LivesOnLand);
        }

        /// <summary>
        /// Verifies that class overrides method from base class
        /// </summary>
        [Fact]
        public void Bear_OverridesGiveBirth()
        {
            Bear bear = new Bear();
            Assert.Equal(2, bear.GiveBirth(2));
        }

        /// <summary>
        /// Verifies that class inherits base class data type
        /// </summary>
        [Fact]
        public void Bear_IsAnimal()
        {
            Animal bear = new Bear();
            Assert.True(bear.LivesOnLand);
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Bear implements IEat (inherited from Animal).
        /// Weasel implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Bear_Eats_Weasel()
        {
            Bear bear = new Bear();
            Weasel weasel = new Weasel();
            Assert.True(bear.Eat(weasel));
        }

    }
}
