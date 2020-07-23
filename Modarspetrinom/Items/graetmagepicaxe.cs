//Created by KeysCG | Видеоуроки по моддингу террарии: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modarspetrinom.Items //название вашего мода
{
    public class graetmagepicaxe : ModItem //название вашего скрипта
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Great mage pikaxe"); //название объекта в игре
            Tooltip.SetDefault("Strong but us mana"); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.damage = 9; // значение урона
            item.magic = true;   //тип оружия "melee" - ближнего боя в руках
            item.width = 64; //ширина спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.height = 64; //высота спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.useTime = 9; //???
            item.useAnimation = 11; //???
            item.pick = 60;    //сила кирки
            item.axe = 15;
            item.mana = 3; 
            item.useStyle = 1; //тип использования "1" - для размахивания
            item.knockBack = 6; //сила отбрасования "максимальное значение 20"
            item.value = 100000000; //стоимость в медных монетах
            item.rare = 3; //редкость от -1 до 13
            item.UseSound = SoundID.Item1; //звук объекта
            item.autoReuse = true; //если зажата мышь то предмет работает непрерывно
            item.useTurn = true; //может ли персонаж обернуться во время работы
        }
        public override void AddRecipes()  //Крафт
        {
            ModRecipe recipe = new ModRecipe(mod); //запуск рецепта
            recipe.AddIngredient(ItemID.ManaCrystal, 5);   //материал из которого будет крафтиться и количество
            recipe.AddIngredient(mod, "lever", 9 );
            recipe.AddIngredient(ItemID.FallenStar, 30);
            recipe.AddIngredient(ItemID.Emerald, 4);
            recipe.AddTile(TileID.DemonAltar);   //на чём будет крафтиться
            recipe.SetResult(this); //что мы получим в итоге 
            recipe.AddRecipe(); //завершение крафта
        }
    }
}