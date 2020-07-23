//Created by KeysCG | Видеоуроки по моддингу террарии: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modarspetrinom.Items //название вашего мода
{
    public class dragonpicaxe : ModItem //название вашего скрипта
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dragon Pickaxe"); //название объекта в игре
            Tooltip.SetDefault("Omg that pickaxe"); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.damage = 1; // значение урона
            item.melee = true; //тип оружия "melee" - ближнего боя в руках
            item.width = 64; //ширина спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.height = 64; //высота спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.useTime = 000001; //???
            item.useAnimation = 000001; //???
            item.pick = 4000;    //сила кирки
            item.axe = 4000;
            item.useStyle = 1; //тип использования "1" - для размахивания
            item.knockBack = 6; //сила отбрасования "максимальное значение 20"
            item.value = 100000000; //стоимость в медных монетах
            item.rare = -12; //редкость от -1 до 13
            item.UseSound = SoundID.Item1; //звук объекта
            item.autoReuse = true; //если зажата мышь то предмет работает непрерывно
            item.useTurn = true; //может ли персонаж обернуться во время работы
        }
        public override void AddRecipes()  //Крафт
        {
            ModRecipe recipe = new ModRecipe(mod); //запуск рецепта
            recipe.AddIngredient(ItemID.LunarBar, 880 );   //материал из которого будет крафтиться и количество
            recipe.AddIngredient(mod, "lever", 120 );
            recipe.AddIngredient(ItemID.PickaxeStatue );
            recipe.AddIngredient(ItemID.CactusPickaxe );
            recipe.AddIngredient(ItemID.BonePickaxe );
            recipe.AddIngredient(ItemID.NightmarePickaxe );
            recipe.AddIngredient(ItemID.MoltenPickaxe );
            recipe.AddIngredient(ItemID.CobaltPickaxe );
            recipe.AddIngredient(ItemID.MythrilPickaxe );
            recipe.AddIngredient(ItemID.AdamantitePickaxe );
            recipe.AddIngredient(ItemID.PickaxeAxe );
            recipe.AddIngredient(ItemID.ChlorophytePickaxe );
            recipe.AddIngredient(ItemID.Picksaw );

            

            recipe.AddTile(TileID.DemonAltar);   //на чём будет крафтиться
            recipe.SetResult(this); //что мы получим в итоге 
            recipe.AddRecipe(); //завершение крафта
        }
    }
}