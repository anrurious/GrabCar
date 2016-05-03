//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrabCarMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_driver
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string picture { get; set; }
        public string bio { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public Nullable<int> dog_id { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public Nullable<int> token_expiry { get; set; }
        public string device_token { get; set; }
        public string device_type { get; set; }
        public string login_by { get; set; }
        public string social_unique_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<decimal> latitude { get; set; }
        public Nullable<decimal> longitude { get; set; }
        public Nullable<decimal> debt { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<long> rate_count { get; set; }
        public Nullable<long> promo_count { get; set; }
        public Nullable<int> is_referee { get; set; }
        public string user_type { get; set; }
        public string gcm_reg_id { get; set; }
        public string current_location_road { get; set; }
        public string car_no { get; set; }
        public string car_model_no { get; set; }
        public string manufacture_year { get; set; }
        public string car_type { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string present_address { get; set; }
        public string license_image { get; set; }
        public string nid_image { get; set; }
        public string brtc_image { get; set; }
        public string insurance_image { get; set; }
        public Nullable<int> status { get; set; }
    }
}
