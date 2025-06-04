using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftInAction : Form
    {
        Obstacle obstacle;
        public ShinobiShiftInAction()
        {
            InitializeComponent();
            this.Load += ShinobiShiftInAction_Load;
        }

        private void ShinobiShiftInAction_Load(object sender, EventArgs e)
        {
            //障害物を生成してフィールドに格納
            var obstacle = new Obstacle(1100, 0, 100, 100, this);

        }


    }


    
      


       


}
