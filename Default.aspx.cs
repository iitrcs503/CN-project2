using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    data_layer dl = new data_layer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            Label1.Text = "";
            Label4.Text = "";
            Label3.Text = "";
            Label7.Text = "";
            Label11.Text = "";
            Panel3.Visible = false; // cost benefit panel
            //Panel2.Visible = false;
        }
        

    }

   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedIndex==0)
        {
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "Invalid selection,select a country name";
        }
        if(DropDownList1.SelectedIndex==1)
        {
            var q = dl.show_data();
            if(q.Any())
            {
                GridView1.DataSource = q;
                GridView1.DataBind();
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "No Data Present";
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "Invalid selection,select a country name";
        }
        Panel3.Visible = false;
        RadioButton1.Checked = false;
        Panel2.Visible = true;
        string c1_name, c2_name;
        c2_name = "initial null";
        c1_name = DropDownList1.SelectedValue;
        int c4=-111;
        string country = DropDownList1.SelectedValue;
        string s = TextBox1.Text;
        string str = s.Trim();
        int c1,c2,c3; // c1= num value of client's current country  ,c2=country having the file requested,can also be server,c3=cost of file transfer
        c2 = -11;  // just initialising,no meanning of c3=-11
        c1=10*(DropDownList1.SelectedIndex);
        Label3.Text = c1.ToString();
                            
                

        var q = dl.search1(str,country);
        
        if (q.Any())
        {
            
            Label1.ForeColor = System.Drawing.Color.Green;
            Label1.Text = "File found in my country";
            Label4.Text = "";
            foreach (Table1 k in q)
            {
                k.count = k.count + 1;
                var d = dl.show_data();
                foreach (Table1 kd in d)
                {
                    if (kd.name == k.name && kd.wher == "server" && kd.owner == "server")
                    {
                        kd.count = k.count;
                    }
                    dl.da.SubmitChanges();
                }
            }
            dl.da.SubmitChanges();
            foreach (Table1 k in q)
            {
                Label4.ForeColor = System.Drawing.Color.Green;
                Label4.Text = k.wher;
                if (k.wher == "australia") { c2 = 10; c2_name = "australia"; }
                else if (k.wher == "brazil") { c2 = 20; c2_name = "brazil"; }
                else if (k.wher == "china") { c2 = 30; c2_name = "china"; }
                else if (k.wher == "england") { c2 = 40; c2_name = "england"; }
                else if (k.wher == "france") { c2 = 50; c2_name = "france"; }
                else if (k.wher == "india") { c2 = 60; c2_name = "india"; }
                else if (k.wher == "japan") { c2 = 70; c2_name = "japan"; }
                else if (k.wher == "russia") { c2 = 80; c2_name = "russia"; }
                else if (k.wher == "south africa") { c2 = 90; c2_name = "south africa"; }
                else if (k.wher == "usa") { c2 = 100; c2_name = "usa"; }
                else { c2 = 55; c2_name = "server"; }
               Label7.Text = c2.ToString();
               
            }
            c3 = Math.Abs(c1 - c2);
            Label11.Text = c3.ToString();
            c4 = 0; // and not  Math.Abs(c1 - 55) because tradionally also if file is in the same country then file wont be imported for the server again
            dl.submit_cost(c1_name, c1, c2_name, c2, c3, c4, Math.Abs(c3 - c4));

        }
        else
        {
            
            var q1 = dl.search2(str, country);
            if (q1.Any())
            {
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "File found in other country";
                Label4.Text = "";
                foreach (Table1 k in q1)
                {
                    k.count = k.count + 1;  // k contains the "row having country" currenty storing the requested file
                    var d = dl.show_data();
                    foreach(Table1 kd in d)
                    {
                        if(kd.name==k.name && kd.wher=="server" && kd.owner=="server")
                        {
                            kd.count = k.count;
                        }
                        dl.da.SubmitChanges();
                    }
                }
                dl.da.SubmitChanges();
                foreach (Table1 k in q1)
                {
                    Label4.ForeColor = System.Drawing.Color.Green;
                    Label4.Text = k.wher;
                    if (k.wher == "australia") { c2 = 10; c2_name = "australia"; }
                    else if (k.wher == "brazil") { c2 = 20; c2_name = "brazil"; }
                    else if (k.wher == "china") { c2 = 30; c2_name = "china"; }
                    else if (k.wher == "england") { c2 = 40; c2_name = "england"; }
                    else if (k.wher == "france") { c2 = 50; c2_name = "france"; }
                    else if (k.wher == "india") { c2 = 60; c2_name = "india"; }
                    else if (k.wher == "japan") { c2 = 70; c2_name = "japan"; }
                    else if (k.wher == "russia") { c2 = 80; c2_name = "russia"; }
                    else if (k.wher == "south africa") { c2 = 90; c2_name = "south africa"; }
                    else if (k.wher == "usa") { c2 = 100; c2_name = "usa"; }
                    else { c2 = 55; c2_name = "server"; }
                    Label7.Text = c2.ToString();
                }
                c3 = Math.Abs(c1 - c2);
                Label11.Text = c3.ToString();
                c4 = Math.Abs(c1 - 55);
                dl.submit_cost(c1_name, c1, c2_name, c2, c3, c4, Math.Abs(c3 - c4));

                // exchange this file (from neighbour) with client's country's least popular file
                int min_count = 9999;
                string min_wher = "";
                string min_owner = "";
                string min_name = "";
                var q4 = dl.least_popular(country);
                foreach (Table1 k in q4)
                {
                    if (k.count < min_count)
                    {
                        min_count = k.count;
                        min_wher = k.wher; // no use of this variable,just for understanding
                        min_owner = k.owner;// make "min_owner" as the owner of this file at neighbour
                        min_name = k.name; // min_name is the least popular file

                    }
                }
                // $ STARTS:  client's country's least popular file is sent to the neighbour having requested file  
                foreach (Table1 k in q4)
                {
                    if (k.wher == min_wher)
                    {
                        dl.da.Table1s.DeleteOnSubmit(k);  // least pop file deleted from client country
                        dl.da.SubmitChanges();
                        min_wher = Label4.Text;  // Label4.text= name of neighbouring country containing the requested file
                    }
                }
                dl.submit_file(min_name,min_owner,min_wher,min_count); //client's country's least pop file added to neighbour having requested file
                // $ ENDS
                
                

                //# STARTS: requested file is sent back to the client's country from neighbour containg it
                var q7 = dl.search2(str, country);
                foreach(Table1 ks in q7)
                {
                    min_name = ks.name; // ks.name = str= file requested by client
                    min_count=ks.count;
                    min_owner = ks.owner;
                    min_wher = country;
                    dl.da.Table1s.DeleteOnSubmit(ks);  // file requested by client deleted from neighbour country having it
                    dl.da.SubmitChanges();
                }
                dl.submit_file(min_name, min_owner, min_wher, min_count); //file requested by client added to client's country
                // # ENDS

                // Exchange file finishes
                

            }
            else
            {
                
                var q2 = dl.search3(str);
                if (q2.Any())
                {
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "File found in server";
                    Label4.Text = "";
                    int k_count=0;
                    foreach (Table1 kk in q2)
                    {
                        kk.count = kk.count + 1;
                       k_count = kk.count;
                    }
                    dl.da.SubmitChanges();
                    foreach (Table1 k in q2)
                    {
                        Label4.ForeColor = System.Drawing.Color.Green;
                        Label4.Text = k.wher;
                        if (k.wher == "australia") { c2 = 10; c2_name = "australia"; }
                        else if (k.wher == "brazil") { c2 = 20; c2_name = "brazil"; }
                        else if (k.wher == "china") { c2 = 30; c2_name = "china"; }
                        else if (k.wher == "england") { c2 = 40; c2_name = "england"; }
                        else if (k.wher == "france") { c2 = 50; c2_name = "france"; }
                        else if (k.wher == "india") { c2 = 60; c2_name = "india"; }
                        else if (k.wher == "japan") { c2 = 70; c2_name = "japan"; }
                        else if (k.wher == "russia") { c2 = 80; c2_name = "russia"; }
                        else if (k.wher == "south africa") { c2 = 90; c2_name = "south africa"; }
                        else if (k.wher == "usa") { c2 = 100; c2_name = "usa"; }
                        else { c2 = 55; c2_name = "server"; }
                        Label7.Text = c2.ToString();
                    }
                    c3 = Math.Abs(c1 - c2);
                    Label11.Text = c3.ToString();
                    c4 = Math.Abs(c1 - 55);  // tradionally this file wud have been brought form the server
                    dl.submit_cost(c1_name, c1, c2_name, c2, c3, c4, Math.Abs(c3 - c4));

                    int count;
                    count= dl.coun(DropDownList1.SelectedValue);
                    //Label9.Text = count.ToString();
                    if(count<3)
                    {
                        dl.submit_file(str, country,country, k_count); //add the server brought file into cdn cache
                       // Label12.Text = "count<3";

                    }
                    else   // least popular file is to be replaced nd put somewhere else(at a neighbouring node) now
                    {
                       // Label12.Text = "count !<3";
                        var q4 = dl.least_popular(country);
                        int min_count = 9999;
                        string min_wher = "";
                        string min_owner = "";
                        string min_name = "";
                        int temp_min_count = 9999;   // used in main logic loop
                        string temp_min_wher = ""; // used in main logic loop
                        string temp_min_owner = ""; // used in main logic loop
                        string temp_min_name = ""; // used in main logic loop
                        foreach (Table1 k in q4)
                        {
                            if (k.count < min_count)
                            {
                                min_count = k.count; 
                                min_wher = k.wher; // no use of this variable,just for understanding
                                min_owner = k.owner;// make "min_owner" as the owner of this file at neighbour
                                min_name = k.name; // min_name is the least popular file

                            }
                        }
                        //DLT BELOW LINE
                       // Label13.Text = "min name is  " + min_name;

                        //dlt this least popular file form cdn cache
                        foreach (Table1 k in q4)
                        {
                            if (k.name==min_name)
                            {
                                dl.da.Table1s.DeleteOnSubmit(k);
                                dl.da.SubmitChanges();
                              //  Label13.Text = "least pop file deleted  "+k.name;
                            }
                        }
                        //add the server brought file into cdn cache
                        dl.submit_file(str, country,country, k_count);
                       // Label14.Text = "server brought file added  "+str;

                        var q5=dl.get_all_country(); //q5 contains table "Countrylist" of details of all countries
                        Countrylist cl;
                        string nation = country;
                        int minim;
                        int k_id = -1;
                        int [] visited={0,0,0,0,0,0,0,0,0,0,0};  //to mark if a country has been checked or not
                        //Label15.Text = "nation is " + nation;
                        for(int i=1;i<=10;i++)
                        {
 /* main logic satrts*/    cl = null;
 /*at loop start nation*/  k_id = -1;
 /*nd min_name needed */   minim = 9999;
 /*cl be null initialised*/
                          foreach (Countrylist k in q5)
                            {
   
                              
                              if(Math.Abs(k.num-c1)< Math.Abs(55-c1) && k.name!=nation)
                                {
                                    if(Math.Abs(k.num-c1)<minim && visited[k.Id]==0)
                                    {
                                        minim = Math.Abs(k.num - c1);
                                        cl = k; // cl is containg the row having "nearest neighbour" of client's country
                                        k_id = k.Id;
                                    }
                                }
                            }
                            visited[k_id] = 1;
                           // Label15.Text = "cl is: " + cl.name;
                            if (cl == null)
                                {
                                //  Label16.Text = "import from server is better";
                                  break; //the least popular file is less costly to be brought from main server hence not placing at ny neighbor
                                  
                                }
                           
                            //else following will be executed:
                            count = dl.coun(cl.name);
                            if(count<3)
                            {
                                // add this file into currenct cdn server cache
                                dl.submit_file(min_name, min_owner,cl.name, min_count); //owner is min_owner and wher is cl.name
                               // Label16.Text = "space available nd file stored at "+cl.name;
                                break; //empty sapce found at neighbour, no more computation needed now
                            }
                            else // cache full so the new "least pop file" is to be replaced from "nation"
                            {
                                // add this file into currenct cdn server cache
                   /*DXT*/ //      dl.submit_file(min_name, min_owner, cl.name, min_count); //owner is min_country and wher is cl.name


                                nation = cl.name; // now the country where file replacement is being done is cl.name 
                                c1=cl.num; // c1 now contains num i.e cost value of new nation
                                q4 = dl.least_popular(nation); //q4 contains all rows of country=nation
                          /*DXT*/      temp_min_count = 9999;
                          /*DXT*/      temp_min_owner = "";
                          /*DXT*/      temp_min_name = "";
                          /*DXT*/      temp_min_wher = "";
                                foreach (Table1 k in q4)
                                {
                                    if (k.count < temp_min_count)
                                    {
                                        temp_min_count = k.count;
                                        temp_min_owner = k.owner; // make "min_owner" as the owner of this file at neighbour
                                        temp_min_wher = k.wher; // no use of this variable,just for understanding
                                        temp_min_name = k.name; // min_name is the least popular file

                                    }
                                }

                                if(temp_min_count<min_count)
                                {
                               /*DXT*/     dl.submit_file(min_name, min_owner, cl.name, min_count);//Insert min_name

                                    min_name = temp_min_name;//Update min_name=temp_min_count name etc 
                                    min_owner = temp_min_owner;
                                    min_wher = temp_min_wher;
                                    min_count = temp_min_count;

                                    //dlt this least popular file from 'nation' cache
                                    var q6 = dl.least_popular(nation);
                                    foreach (Table1 k in q6)
                                    {
                                        if (k.name == temp_min_name)
                                        {
                                            dl.da.Table1s.DeleteOnSubmit(k);
                                            dl.da.SubmitChanges();
                                        }
                                    }
                                }
                               
                                
                            }

                        }
                        
                    }
                        
                }
                else
                {
                    Label4.ForeColor = System.Drawing.Color.Red;
                    Label4.Text = "File NOT found";
                    Label3.Text = "";
                    Label7.Text = "";
                }
            }
            

        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
            Panel3.Visible = true;
    }
}