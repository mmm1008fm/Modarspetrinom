//Created by KeysCG "www.youtube.com/keysrec"
using Terraria.ID;
using Terraria.ModLoader;

namespace Modarspetrinom.Items //�������� ���� "NameMods"
{
    public class lever : ModItem //�������� ������� "NameScript"
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lever"); //�������� ������� � ����
            Tooltip.SetDefault("This is a regular grip."); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.width = 20; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 20; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.maxStack = 100; //������������ ���������� ���� � �����
            item.value = 50; //��������� � ������ ������� "100" - ��� 1 �������
            item.rare = 0; //�������� ������ �������
        }

        public override void AddRecipes() //�������� ������
        {
            ModRecipe recipe = new ModRecipe(mod); //����� ������
            recipe.AddIngredient(ItemID.Wood, 200); //����������� �� ������� ��������� ������ "DirtBlock" - ����� "10" - ����������
            recipe.AddTile(TileID.WorkBenches); //����� ��� ������ "WorkBenches" - �������
            recipe.SetResult(this, 3); //��� ������� ����� ������ "this" - ���� ������ "1" - ���������� ����
            recipe.AddRecipe();
        }
    }
}