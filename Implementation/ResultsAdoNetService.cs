﻿//using EXAM.Abstract;
//using EXAM.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

//namespace EXAM.Implementation
//{
//    public class ResultsAdoNetService : GetConnection, IResults
//    {
//    public Results Create(Results model) {
//      try {

//        using (SqlConnection db = getConn) {
//          db.Open();
//          using (SqlCommand cmd = new SqlCommand("pCountrySelectById @Id", db)) {
//            cmd.Parameters.AddWithValue("@Id", model.Id);
//            SqlDataReader dr = cmd.ExecuteReader();
//            dr.Read();
//            Results result = new Results {
//               = dr["Capital"].ToString(),
//              Name = dr["Name"].ToString(),
//              Population = int.Parse(dr["Population"].ToString())
//            };
//            db.Close();
//            return result;
//          }
//        }

//        using (SqlConnection db = getConn) {
//          db.Open();
//          using (SqlCommand cmd = new SqlCommand("pAnswerCreate  @FirstName,@LastName, @q1,@q2,@q3, @q4, @q5,@end_date ", db)) {
//            cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
//            cmd.Parameters.AddWithValue("@LastName", model.LastName);
//            cmd.Parameters.AddWithValue("@q1", model.q1);
//            cmd.Parameters.AddWithValue("@q2", model.q2);
//            cmd.Parameters.AddWithValue("@q3", model.q3);
//            cmd.Parameters.AddWithValue("@q4", model.q4);
//            cmd.Parameters.AddWithValue("@q5", model.q5);
//            cmd.Parameters.AddWithValue("@end_date", model.end_date);

//            cmd.ExecuteNonQuery();
//            db.Close();
//            return model;
//          }
//        }

      
//      } catch (Exception err) {
//        string mess = err.Message;
//        return null;
//      }
//    }






//  }
//}