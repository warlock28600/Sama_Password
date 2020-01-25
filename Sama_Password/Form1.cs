using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Sama_Password
{
    public partial class sama_pass : Form
    {
        public sama_pass()
        {
            InitializeComponent();
        }

        private void Sama_pass_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string pas_medical_shahed = "USE Behdasht  SELECT dbo.getkeycode(keycode),* from USERBIN where IsMartyrsAndVeteransPortalUser=1";
            string pas_sience_shahed = "در حال حاضر سیستم شاهد برای وزارت علوم وجود ندارد ";
            if (rb_Shahed_medical.Checked)
            {
                txt_Shahed.Clear();
                Clipboard.Clear();
                Clipboard.SetText(pas_medical_shahed);
                txt_Shahed.Text = pas_medical_shahed;
            }
            else if (rb_Shahed_Sience.Checked)
            {
                txt_Shahed.Clear();
                Clipboard.Clear();
                MessageBox.Show(pas_sience_shahed, txt_Caption);

            }
            else { MessageBox.Show(txt_Warning, txt_Caption); }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        string txt_Warning = "لطفا نوع دانشگاه را انتخاب کنید ";
        string txt_Caption = "هشدار";
        // sa button
        private void btn_Sa_Click(object sender, EventArgs e)
        {
            
            string Sa_old = "ï@4Ak\\18Xydq3CouI~w:ôvg79‰pNfü5(|-S;€ƒrT½H}6 je?)0<*=%{è$‹mBLz@2";
       
                             
            string Sa_new = "Kü<y|v:ôè>ï65DEh!Jlg2?s)q@fMr9-‹€1ƒzIn‰W=PC}B;%$_x(8^{½+u*~\\0&3A";
            if (rb_New.Checked)
            {
                txt_Sa.Clear();
                txt_Sa.Text = Sa_new;
                Clipboard.SetText(Sa_new);
              
            }
             else if (rb_Old.Checked)
            {
                txt_Sa.Clear();
                Clipboard.Clear();
                Clipboard.SetText(Sa_old);
                txt_Sa.Text=Sa_old;

            }
            else { MessageBox.Show("لطفا جدید و قدیمی بودن را انتخاب کنید ", txt_Caption); }
        }
        //samasupport Button
        private void btn_Samasupport_Click(object sender, EventArgs e)
        {
            string SamaSupport_Old = "R3AXJbfEActgszc25njU0Qajf8R5OsezZGTWhgIprUMqdxRnX3N1SbKILghVjvrx";
            string SamaSupport_New = "R3AXJbfEActgszc25njU0Qajf8R5OsezZGTWhgIprUMqdxRnX3N1SbKILghVjvrx";
            if (rb_New.Checked)
            {
                txt_Samasupport.Clear();
                Clipboard.Clear();
                Clipboard.SetText(SamaSupport_New);
                txt_Samasupport.Text = SamaSupport_New;

            }
            else if (rb_Old.Checked)
            {
                txt_Samasupport.Clear();
                Clipboard.Clear();
                Clipboard.SetText(SamaSupport_Old);
                txt_Samasupport.Text = SamaSupport_Old;
            }
            else { MessageBox.Show(txt_Warning, txt_Caption); }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        // education Button
        private void btn_Education_Click(object sender, EventArgs e)
        {
            string  pas_Medical = "USE Behdasht  SELECT dbo.getkeycode(keycode),* from USERBIN where accesscode=1";
            string pas_sience =   "USE UEMS  SELECT dbo.getkeycode(keycode),* from USERBIN where accesscode=1 ";

            if (rb_Edu_medical.Checked)
            {
                Clipboard.Clear();
                Clipboard.SetText(pas_Medical);
                txt_Education.Clear();
                txt_Education.Text = pas_Medical;
            }
            else if (rb_Edu_Sience.Checked)
            {
                Clipboard.Clear();
                Clipboard.SetText(pas_sience);
                txt_Education.Clear();
                txt_Education.Text = pas_sience;
            }
            else { MessageBox.Show(txt_Warning, txt_Caption); }



        }
        // finance Button
        private void btn_Finance_Click(object sender, EventArgs e)
        {
            string medical_finance = "USE behdasht select dbo.getretstrcode(password,0), *  from users where access_code=1";
            string sience_finance =  "USE UEMS select dbo.getretstrcode(password,0), *  from users where access_code=1";

            if (rb_Finance_medical.Checked)
            {
                Clipboard.Clear();
                Clipboard.SetText(medical_finance);
                txt_Finance.Clear();
                txt_Finance.Text =medical_finance;
            }
            else if (rb_Finance_sience.Checked)
            {
                Clipboard.Clear();
                Clipboard.SetText(sience_finance);
                txt_Finance.Clear();
                txt_Finance.Text = sience_finance;
            }
            else { MessageBox.Show(txt_Warning, txt_Caption); }
        }

        private void btn_Evaluation_Click(object sender, EventArgs e)
        {
            string Pass_medical_Eval = "USE Behdasht  SELECT dbo.getkeycode(keycode),* from USERBIN where IsEvaluationUser=1";
            string Pass_sience_Eval = "USE Uems  SELECT dbo.getkeycode(keycode),* from USERBIN where IsEvaluationUser=1";
            if (rb_evaluation_Medical.Checked)
            {
                Clipboard.Clear();
                txt_Evaluation.Clear();
                Clipboard.SetText(Pass_medical_Eval);
                txt_Evaluation.Text = Pass_medical_Eval;
            }
            else if (rb_evaluation_Sience.Checked)
            {
                Clipboard.Clear();
                txt_Evaluation.Clear();
                Clipboard.SetText(Pass_sience_Eval);
                txt_Evaluation.Text = Pass_sience_Eval;
            }
            else { MessageBox.Show(txt_Warning, txt_Caption); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pass_medical_Talented = "USE Behdasht  SELECT dbo.getkeycode(keycode),* from USERBIN where IsTalentedUser=1";
            string pass_siense_Talented = "در حال حاضر سیستم استعداد درخشان برای وزارت علوم وجود ندارد ";
            if (rb_Talented_Medical.Checked)
            {
                txt_Talented.Clear();
                Clipboard.Clear();
                Clipboard.SetText(pass_medical_Talented);
                txt_Talented.Text = pass_medical_Talented;
            }
            else if (rb_Talented_Siense.Checked)
            {
                txt_Talented.Clear();
                Clipboard.Clear();
                MessageBox.Show(pass_siense_Talented, txt_Warning);
            }
            else { MessageBox.Show(txt_Warning, txt_Caption); }
        }

        private void btn_Teachersalary_Click(object sender, EventArgs e)
        {
            string pass_teachersalary = "USE Teachersalary select behdasht.dbo.getkeycode(KeyCode),* from teachersalary.dbo.userbin";
            Clipboard.Clear();
            txt_Teachersalary.Clear();
            Clipboard.SetText(pass_teachersalary);
            txt_Teachersalary.Text = pass_teachersalary;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            string txt_studentno = txt_stno.Text;
            txt_stdkey.Clear();
            txt_stdkey.Text = ("select dbo.GetKeyCode(KeyCode),* from stdkey where stno="+"'"+ txt_studentno +"'") ;
        }

        private void btn_ostad_Click(object sender, EventArgs e)
        {
            string txt_donkeycode = txt_doncode.Text;
            txt_doncode.Clear();
            txt_donkey.Text = ("select dbo.GetKeyCode(KeyCode),* from stdkey where doncode=" + "'" + txt_donkeycode + "'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string data03 = txt_Data03.Text;
            Clipboard.Clear();
            Clipboard.SetText(data03);
        }

        private void btn_delete_Data01_Click(object sender, EventArgs e)
        {
            txt_Data01.Clear();
        }

        private void btn_copy_Data01_Click(object sender, EventArgs e)
        {
            string data01 = txt_Data01.Text;
            Clipboard.Clear();
            Clipboard.SetText(data01);
        }

        private void btn_delete_Data02_Click(object sender, EventArgs e)
        {
            txt_Data02.Clear();
        }

        private void btn_copy_Data02_Click(object sender, EventArgs e)
        {
            string data02 = txt_Data02.Text;
            Clipboard.Clear();
            Clipboard.SetText(data02);
        }

        private void btn_delete_Data03_Click(object sender, EventArgs e)
        {
            txt_Data03.Clear();
        }

        private void btn_delete_Data04_Click(object sender, EventArgs e)
        {
            txt_Data04.Clear();
        }

        private void btn_copy_Data04_Click(object sender, EventArgs e)
        {
            string data04 = txt_Data04.Text;
            Clipboard.Clear();
            Clipboard.SetText(data04);
        }

        private void btn_delete_Data05_Click(object sender, EventArgs e)
        {
            txt_Data05.Clear();
        }

        private void btn_copy_Data05_Click(object sender, EventArgs e)
        {
            string data05 = txt_Data05.Text;
            Clipboard.Clear();
            Clipboard.SetText(data05);
        }

        private void btn_delete_Data06_Click(object sender, EventArgs e)
        {
            txt_Data06.Clear();

        }

        private void btn_copy_Data06_Click(object sender, EventArgs e)
        {
            string dat06 = txt_Data06.Text;
            Clipboard.Clear();
            Clipboard.SetText(dat06);
        }

        private void btn_delete_Data07_Click(object sender, EventArgs e)
        {
            txt_Data07.Clear();
        }

        private void btn_copy_Data07_Click(object sender, EventArgs e)
        {
            string data07 = txt_Data07.Text;
            Clipboard.Clear();
            Clipboard.SetText(data07);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ltr.Clear();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            string ltr = txt_ltr.Text;
            Clipboard.Clear();
            Clipboard.SetText(ltr);
        }
        

        private void Button3_Click_1(object sender, EventArgs e)
        {
            int status=0;
            if (rb_Complete.Checked)  
            {
                status = 1;
            }
            else if (rb_Incomplte.Checked)
            {
                status = 2;
            }
            int place = 0;
            if (rb_Indoor.Checked)
            {
                place = 1;
            }
            else if(rb_UniversityPlace.Checked)
            {
                place = 2;
            }
            else if (rb_Virtual.Checked)
            {
                place = 3;
            }
            int isuserteaching = 0;
             if(cb_AmoozeshKarbari.Checked)
            {
                isuserteaching = 1;
            }
            else { isuserteaching = 0; }
            int issecondteachig = 0;
            if (cb_AmoozeshMojadad.Checked)
            {
                issecondteachig = 1;

            }
            else { issecondteachig = 0;}
            int isproblemsolving=1;
            if(cb_RafeEshkal.Checked)
            {
                isproblemsolving = 1;
            }
            else { isproblemsolving = 0;}
            int isServerchange = 0;
            if(cb_ServerChange.Checked)
            {
                isServerchange = 1;
            }
            else { isServerchange = 0; }
            int issqlinstall = 0;
            if(cb_SqlInstall.Checked)
            {
                issqlinstall = 1;
            }
            else { issqlinstall = 0;}
            int issysteminstall = 0;
            if(cb_newinstall.Checked)
            {
                issysteminstall = 1;

            }
            else { issysteminstall = 0;}
            int Amoozesh = 0;
            if(cb_Amoozesh.Checked)
            {
                Amoozesh = 1;
            }
            else
            {
                Amoozesh = 0;
            }
            int Mali=0;
                if (cb_Mali.Checked)
            {
                Mali = 1;
            }
            else
            {
                Mali = 0;
            }
            int Evaluation = 0;

            if (cb_Arzesh.Checked)
            {
                Evaluation = 1;
            }
            else { Evaluation = 0; }
            int Talented = 0;
            if (cb_talented.Checked)
            {
                Talented = 1;
            }
            else { Talented = 0; }
            int Shahed = 0;
            if (cb_Shahed.Checked)
            {
                Shahed = 1;
            }
            else { Shahed = 0; }
            int Das = 0;
            if(cb_Das.Checked)
            {
                Das = 1;
            }
            else { Das = 0; }
            int Nutrition = 0;
            if (cb_Nutrition.Checked)
            {
                Nutrition = 1;
            }
            else { Nutrition = 0; }
            int TeacherSalary = 0;
            if (cb_TeacherSalary.Checked)
            {
                TeacherSalary = 1;
            }
            else { TeacherSalary = 0; }
            int Proposal = 0;
            if(cb_proposal.Checked)
            {
                Proposal = 1;
            }
            else { Proposal = 0; }

            MainSession_Inset insertdata = new MainSession_Inset();
            
            insertdata.status=status;
            insertdata.Place = place;
            insertdata.isUserTeachig = isuserteaching;
            insertdata.isSecondTeaching = issecondteachig;
            insertdata.isProblemSolving = isproblemsolving;
            insertdata.isServerChanging = isServerchange;
            insertdata.isSqlInstall = issqlinstall;
            insertdata.isSystemInstall = issysteminstall;
            insertdata.isAmoozesh = Amoozesh;
            insertdata.isMali = Mali;
            insertdata.isEvaluation = Evaluation;
            insertdata.isTeacherSalary = TeacherSalary;
            insertdata.isShahed = Shahed;
            insertdata.isTalented = Talented;
            insertdata.isProposal = Proposal;
            insertdata.isDoormitory = Das;
            insertdata.isNutrition = Nutrition;
            insertdata.startdate = mt_StartDate.Text;
            insertdata.enddate = mt_EndDate.Text;
            insertdata.starttime = mt_StartTime.Text;
            insertdata.endtime = mt_EndTime.Text;
            insertdata.explane = tx_Explane.Text;
            insertdata.MainPerson = tx_MainPerson.Text;
            insertdata.ficilityname = tx_FicilityName.Text;
            
            






    }


       
        private void sama_pass_Load(object sender, EventArgs e)
        {
            UnitName FacultyList = new UnitName();
           
            Combo_Unit.DataSource = FacultyList.UnitNameListAll();
            Combo_Unit.DisplayMember = "Name";
            Combo_Unit.ValueMember = "Code";
           // Combo_Unit.SelectedValue = "";
            Combo_Unit.Refresh();
           
            
        }
    }
        
}
