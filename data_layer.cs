using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for data_layer
/// </summary>
public class data_layer
{
    public DataClassesDataContext da = new DataClassesDataContext();

    public IEnumerable<Table1>show_data()
    {
        var q = from a in da.Table1s
                select a;
        return q;
    }

    public void submit_data(string name)
    {
        Table1 ser = new Table1();
        ser.name = name;
        ser.count = 0;
        ser.owner = "server";
        ser.wher = "server";
        da.Table1s.InsertOnSubmit(ser);
        da.SubmitChanges();

    }

    public void submit_file(string name,string owner,string wher,int count)
    {
        Table1 ser = new Table1();
        ser.name = name;
        ser.count = count;
        ser.owner = owner;
        ser.wher = wher;
        da.Table1s.InsertOnSubmit(ser);
        da.SubmitChanges();

    }

    public void submit_cost(string c1_name,int c1_cost, string c2_name, int c2_cost, int c3,int c4,int benefit)
    {
        Cost ct = new Cost();
        ct.c1_name = c1_name;
        ct.c1_num = c1_cost;
        ct.c2_name = c2_name;
        ct.c2_num = c2_cost;
        ct.c3 = c3;
        ct.c4 = c4;
        ct.benefit = benefit;
        da.Costs.InsertOnSubmit(ct);
        da.SubmitChanges();

    }
    public IEnumerable<Table1>search1(string value,string country)
    {
        var q = from a in da.Table1s
                where a.name == value && a.wher==country
                select a;
        
        return q;
    }

    public IEnumerable<Table1>least_popular(string country)  //returns back whole table content of country= country paramemter
    {
        var q=from a in da.Table1s
                where a.wher == country
              select a;
        return q;
    }

    public IEnumerable<Table1> search2(string value, string country)
    {
        var q = from a in da.Table1s
                where a.name == value && a.owner == country
                select a;
        return q;
    }

    public IEnumerable<Countrylist> get_all_country()
    {
        var q = from a in da.Countrylists
                select a;
        return q;
    }

    public IEnumerable<Table1> search3(string value)
    {
        var q = from a in da.Table1s
                where a.name == value && a.owner == "server"
                select a;
        return q;
    }

    public int coun(string country)
    {
        //var q=from a in da.Table1s
                //where a.wher == country
        int cc=da.Table1s.Count();
        var q = from a in da.Table1s
                where a.wher==country
                select a;
        return q.Count();


    }
}