using System;
using Xunit;

namespace GameModel.Tests
{
    public class HeroTest
    {
        
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(1000)]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue(int value)
        {
            // Arrange
            var hero = new Hero {HitPoints = value};
            // Act
            var result = hero.IsAlive();
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse()
        {
            var hero = new Hero {HitPoints = 0};
            // Act
            var result = hero.IsAlive();
            // Assert
            Assert.False(result);
        }
        
        [Fact]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse()
        {
            var hero = new Hero {HitPoints = -1};
            // Act
            var result = hero.IsAlive();
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {
            var hero = new Hero {HitPoints = 0, Strength = 4};

            var result = hero.Attack();
            
            Assert.Equal(0, result);
        }

        [Fact]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly()
        {
            var hero = new Hero {HitPoints = 4,Strength = 4};

            var result = hero.Attack();
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue()
        {
            var hero = new Hero {HitPoints = 4,Strength = 4,MainHandWeapon = new Weapon {Attack = 1}};

            var result = hero.Attack();
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void Attack_WithWeapon_ShouldReturnAttackValue()
        {
            var hero = new Hero {HitPoints = 4,Strength = 4, MainHandWeapon = new Weapon{Attack = 5}};

            var result = hero.Attack();
            
            Assert.Equal(10, result);
        }

        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {
            var hero = new Hero {Defence = 0,HitPoints = 4,Strength = 4};
            var opponent = new Hero {Defence = 0,HitPoints = 4,Strength = 4};

            
            hero.Defend(opponent);
            
            Assert.Equal(2, hero.HitPoints);
        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {
            var hero = new Hero {Defence = 1,HitPoints = 4,Strength = 4};
            var opponent = new Hero {Defence = 0,HitPoints = 4,Strength = 4};

            
            hero.Defend(opponent);
            
            Assert.Equal(3, hero.HitPoints);
        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {
            var hero = new Hero {Defence = 0,HitPoints = 4,Strength = 4};
            var opponent = new Hero {Defence = 0,HitPoints = 4,Strength = 10};

            
            hero.Defend(opponent);
            var result = hero.IsAlive();
            
            Assert.Equal(0, hero.HitPoints);
            Assert.False(result);
        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {
            var hero = new Hero {Defence = 0,HitPoints = 4,Strength = 4};
          
            Assert.Throws<ArgumentNullException>(() => hero.Defend(null));
        }
    }
}
