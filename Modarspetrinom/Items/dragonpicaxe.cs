//Created by KeysCG | ���������� �� �������� ��������: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modarspetrinom.Items //�������� ������ ����
{
    public class dragonpicaxe : ModItem //�������� ������ �������
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dragon Picaxe"); //�������� ������� � ����
            Tooltip.SetDefault("Omg that picaxe"); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.damage = 1; // �������� �����
            item.melee = true; //��� ������ "melee" - �������� ��� � �����
            item.width = 64; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 64; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.useTime = 000001; //???
            item.useAnimation = 000001; //???
            item.pick = 4000;    //���� �����
            item.axe = 4000;
            item.useStyle = 1; //��� ������������� "1" - ��� ������������
            item.knockBack = 6; //���� ������������ "������������ �������� 20"
            item.value = 100000000; //��������� � ������ �������
            item.rare = -12; //�������� �� -1 �� 13
            item.UseSound = SoundID.Item1; //���� �������
            item.autoReuse = true; //���� ������ ���� �� ������� �������� ����������
            item.useTurn = true; //����� �� �������� ���������� �� ����� ������
        }
        public override void AddRecipes()  //�����
        {
            ModRecipe recipe = new ModRecipe(mod); //������ �������
            recipe.AddIngredient(ItemID.LunarBar, 5);   //�������� �� �������� ����� ���������� � ����������
            recipe.AddIngredient(mod, "lever" );
            recipe.AddTile(TileID.WorkBenches);   //�� ��� ����� ����������
            recipe.SetResult(this); //��� �� ������� � ����� 
            recipe.AddRecipe(); //���������� ������
        }
    }
}