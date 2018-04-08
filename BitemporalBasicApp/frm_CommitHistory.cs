using BL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitemporalBasicApp
{
    public partial class frm_CommitHistory : Form
    {
        public frm_CommitHistory()
        {
            InitializeComponent();
            viewer.MouseUp += Viewer_MouseUp;
        }



        private void frm_CommitHistory_Load(object sender, EventArgs e)
        {

            List<Commit> listCommit = new CommitBL().getAllCommits();


            //create a viewer object 

            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //  graph.AddNode(listCommit[0].ID.ToString());

            for (int i = 0; i < listCommit.Count; i++)
            {
                /*    Microsoft.Msagl.Drawing.Node n = new Microsoft.Msagl.Drawing.Node(listCommit[0].ID.ToString())*/
                ;

                graph.AddEdge(listCommit[i].commitPrevious.ToString().Substring(0, 5), listCommit[i].name, listCommit[i].commitHash.ToString().Substring(0, 5)).Attr.Color = listCommit[i].branchID == 1 ? Microsoft.Msagl.Drawing.Color.Red : Microsoft.Msagl.Drawing.Color.Green;

                graph.FindNode(listCommit[i].commitHash.ToString().Substring(0, 5)).Id = listCommit[i].ID.ToString();
                graph.FindNode(listCommit[i].commitHash.ToString().Substring(0, 5)).UserData = listCommit[i].branchID;
                graph.FindNode(listCommit[i].commitHash.ToString().Substring(0, 5)).Attr.FillColor = listCommit[i].branchID == 1 ? Microsoft.Msagl.Drawing.Color.Red : Microsoft.Msagl.Drawing.Color.Green;
            }



            graph.FindNode("Start").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

            viewer.Graph = graph;




        }


        private void Viewer_MouseUp(object sender, MouseEventArgs e)
        {
            var gviewer = (Microsoft.Msagl.GraphViewerGdi.GViewer)sender;
            var dnode = gviewer.ObjectUnderMouseCursor as Microsoft.Msagl.GraphViewerGdi.DNode;
            if (dnode == null) return;
            if (dnode.Node.Id != "Start")
            {
                dataGridView1.DataSource = new CommitBL().getAllPersonChangesOnCommit(Convert.ToInt32(dnode.Node.Id));


                dataGridView2.DataSource = new CommitBL().getAllBookChangesOnCommit(Convert.ToInt32(dnode.Node.Id));

                lbl_CommitID.Text = dnode.Node.Id.ToString();
                lbl_CommitName.Text = dnode.Node.InEdges.ToList()[0].LabelText;

                lbl_BranchID.Text = dnode.Node.UserData.ToString();




            }

        }


    }
}
