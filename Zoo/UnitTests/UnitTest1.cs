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
            Animal bear = new Bear();
            Assert.Equal("bear", bear.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Dolphin_CanBeInstantiated()
        {
            Animal dolphin = new Dolphin();
            Assert.Equal("dolphin", dolphin.Species);
        }
        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Lion_CanBeInstantiated()
        {
            Animal lion = new Lion();
            Assert.Equal("lion", lion.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Narwhal_CanBeInstantiated()
        {
            Animal narwhal = new Narwhal();
            Assert.Equal("narwhal", narwhal.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Orca_CanBeInstantiated()
        {
            Animal orca = new Orca();
            Assert.Equal("orca", orca.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Skunk_CanBeInstantiated()
        {
            Animal skunk = new Skunk();
            Assert.Equal("skunk", skunk.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Weasel_CanBeInstantiated()
        {
            Animal weasel = new Weasel();
            Assert.Equal("weasel", weasel.Species);
        }

        /// <summary>
        /// Verifies that class can be instantiated
        /// </summary>
        [Fact]
        public void Wolf_CanBeInstantiated()
        {
            Animal wolf = new Wolf();
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
        /// OtherEdibleCritters implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Bear_Eats_Other()
        {
            Bear eater = new Bear();
            OtherEdibleCritters food = new OtherEdibleCritters();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Dolphin implements IEat (inherited from Animal).
        /// OtherEdibleCritters implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Dolphin_Eats_Other()
        {
            Dolphin eater = new Dolphin();
            OtherEdibleCritters food = new OtherEdibleCritters();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Lion implements IEat (inherited from Animal).
        /// Weasel implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Lion_Eats_Weasel()
        {
            Lion eater = new Lion();
            Weasel food = new Weasel();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Narwhal implements IEat (inherited from Animal).
        /// OtherEdibleCritters implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Narwhal_Eats_Other()
        {
            Narwhal eater = new Narwhal();
            OtherEdibleCritters food = new OtherEdibleCritters();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Orca implements IEat (inherited from Animal).
        /// Narwhal implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Orca_Eats_Narwhal()
        {
            Orca eater = new Orca();
            Narwhal food = new Narwhal();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Bear implements IEat (inherited from Animal).
        /// Weasel implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Orca_Eats_Dolphin()
        {
            Orca eater = new Orca();
            Dolphin food = new Dolphin();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Skunk implements IEat (inherited from Animal).
        /// OtherEdibleCritters implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Skunk_Eats_Other()
        {
            Skunk eater = new Skunk();
            OtherEdibleCritters food = new OtherEdibleCritters();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Weasel implements IEat (inherited from Animal).
        /// OtherEdibleCritters implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Weasel_Eats_Other()
        {
            Weasel eater = new Weasel();
            OtherEdibleCritters food = new OtherEdibleCritters();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// Verifies that interfaces are implemented.
        /// Wolf implements IEat (inherited from Animal).
        /// Weasel implements IAmDinner (directly).
        /// </summary>
        [Fact]
        public void Wolf_Eats_Weasel()
        {
            Wolf eater = new Wolf();
            Weasel food = new Weasel();
            Assert.True(eater.Eat(food));
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Carnivore derivatives override with "walk"
        /// </summary>
        [Fact]
        public void Bear_Walks()
        {
            Mammal traveler = new Bear();
            Assert.Equal("walk", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Carnivore derivatives override with "walk"
        /// </summary>
        [Fact]
        public void Lion_Walks()
        {
            Mammal traveler = new Lion();
            Assert.Equal("walk", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Carnivore derivatives override with "walk"
        /// </summary>
        [Fact]
        public void Skunk_Walks()
        {
            Mammal traveler = new Skunk();
            Assert.Equal("walk", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Carnivore derivatives override with "walk"
        /// </summary>
        [Fact]
        public void Weasel_Walks()
        {
            Mammal traveler = new Weasel();
            Assert.Equal("walk", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Carnivore derivatives override with "walk"
        /// </summary>
        [Fact]
        public void Wolf_Walks()
        {
            Mammal traveler = new Wolf();
            Assert.Equal("walk", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Cetacean derivatives override with "swim"
        /// </summary>
        [Fact]
        public void Orca_Swims()
        {
            Cetacean traveler = new Orca();
            Assert.Equal("swim", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Cetacean derivatives override with "swim"
        /// </summary>
        [Fact]
        public void Narwhal_Swims()
        {
            Cetacean traveler = new Narwhal();
            Assert.Equal("swim", traveler.Travel());
        }

        /// <summary>
        /// verifies that Mammal derivatives override abstract method 'Travel'
        /// Cetacean derivatives override with "swim"
        /// </summary>
        [Fact]
        public void Dolphin_Swims()
        {
            Cetacean traveler = new Dolphin();
            Assert.Equal("swim", traveler.Travel());
        }
    }
}
