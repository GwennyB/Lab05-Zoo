using System;
using Xunit;
using Zoo.Classes;
using Zoo.Interfaces;

namespace UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Bear_CanBeInstantiated()
        {
            Bear bear = new Bear();
            Assert.Equal("bear", bear.Species);
        }
        [Fact]
        public void Dolphin_CanBeInstantiated()
        {
            Dolphin dolphin = new Dolphin();
            Assert.Equal("dolphin", dolphin.Species);
        }
        [Fact]
        public void Lion_CanBeInstantiated()
        {
            Lion lion = new Lion();
            Assert.Equal("lion", lion.Species);
        }
        [Fact]
        public void Narwhal_CanBeInstantiated()
        {
            Narwhal narwhal = new Narwhal();
            Assert.Equal("narwhal", narwhal.Species);
        }
        [Fact]
        public void Orca_CanBeInstantiated()
        {
            Orca orca = new Orca();
            Assert.Equal("orca", orca.Species);
        }
        [Fact]
        public void Skunk_CanBeInstantiated()
        {
            Skunk skunk = new Skunk();
            Assert.Equal("skunk", skunk.Species);
        }
        [Fact]
        public void Weasel_CanBeInstantiated()
        {
            Weasel weasel = new Weasel();
            Assert.Equal("weasel", weasel.Species);
        }
        [Fact]
        public void Wolf_CanBeInstantiated()
        {
            Wolf wolf = new Wolf();
            Assert.Equal("wolf", wolf.Species);
        }

        [Fact]
        public void Bear_InhertsAbstractPropFromAnimal()
        {
            Bear bear = new Bear();
            Assert.False(bear.HangsWithPosse);
        }

        [Fact]
        public void Bear_InheritsConcretePropFromMammal()
        {
            Bear bear = new Bear();
            Assert.True(bear.LivesOnLand);
        }

        [Fact]
        public void Bear_OverridesGiveBirth()
        {
            Bear bear = new Bear();
            Assert.Equal(2, bear.GiveBirth(2));
        }

        [Fact]
        public void Bear_IsAnimal()
        {
            Animal bear = new Bear();
            Assert.True(bear.LivesOnLand);
        }

        [Fact]
        public void Bear_Eats_Weasel()
        {
            Bear bear = new Bear();
            Weasel weasel = new Weasel();
            Assert.True(bear.Eat(weasel));
        }

    }
}
