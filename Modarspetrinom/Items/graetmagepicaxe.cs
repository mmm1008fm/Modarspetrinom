//Created by KeysCG | ���������� �� �������� ��������: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modarspetrinom.Items //�������� ������ ����
{
    public class graetmagepicaxe : ModItem //�������� ������ �������
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Great mage pikaxe"); //�������� ������� � ����
            Tooltip.SetDefault("Strong but us mana"); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.damage = 9; // �������� �����
            item.magic = true;   //��� ������ "melee" - �������� ��� � �����
            item.width = 64; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 64; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.useTime = 9; //???
            item.useAnimation = 11; //???
            item.pick = 60;    //���� �����
            item.axe = 15;
            item.mana = 3; 
            item.useStyle = 1; //��� ������������� "1" - ��� ������������
            item.knockBack = 6; //���� ������������ "������������ �������� 20"
            item.value = 100000000; //��������� � ������ �������
            item.rare = 3; //�������� �� -1 �� 13
            item.UseSound = SoundID.Item1; //���� �������
            item.autoReuse = true; //���� ������ ���� �� ������� �������� ����������
            item.useTurn = true; //����� �� �������� ���������� �� ����� ������
        }
        public override void AddRecipes()  //�����
        {
            ModRecipe recipe = new ModRecipe(mod); //������ �������
            recipe.AddIngredient(ItemID.ManaCrystal, 5);   //�������� �� �������� ����� ���������� � ����������
            recipe.AddIngredient(mod, "lever", 9 );
            recipe.AddIngredient(ItemID.FallenStar, 30);
            recipe.AddIngredient(ItemID.Emerald, 4);
            recipe.AddTile(TileID.DemonAltar);   //�� ��� ����� ����������
            recipe.SetResult(this); //��� �� ������� � ����� 
            recipe.AddRecipe(); //���������� ������
        }
    }
}