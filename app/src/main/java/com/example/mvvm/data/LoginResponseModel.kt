package com.example.mvvm.data

import com.google.gson.annotations.Expose
import com.google.gson.annotations.SerializedName

class LoginResponseModel {

    @SerializedName("ProfileFBR")
    @Expose
    var profileFBRList: MutableList<ProfileFBR>? = mutableListOf()

    @SerializedName("TaxOffices")
    @Expose
    var taxOfficesList: MutableList<TaxOffices> = mutableListOf()

    @SerializedName("Businesses")
    @Expose
    var businessList: MutableList<Businesses> = mutableListOf()

    @SerializedName("Message")
    @Expose
    var messageList: MutableList<Message> = mutableListOf()

    @SerializedName("PREFIX")
    @Expose
    var prefixList: MutableList<DropDownModel> = mutableListOf()

    @SerializedName("SERVICEPROVIDER")
    @Expose
    var providerList: MutableList<DropDownModel> = mutableListOf()

    @SerializedName("CITY")
    @Expose
    var citiesList: MutableList<DropDownModel> = mutableListOf()

}

data class ProfileDataResponse(

    @SerializedName("ProfileFBR") val profileFBR: MutableList<ProfileFBR>,
    @SerializedName("Businesses") val businesses: MutableList<Businesses>,
    @SerializedName("TaxOffices") val taxOffices: MutableList<TaxOffices>,
    @SerializedName("Message") val messages: MutableList<Message>

)

data class ProfileFBR(
    @SerializedName("Computer_No") val Computer_No: Int? = 0,
    @SerializedName("EDN") val EDN: String? = "",
    @SerializedName("Name") val Name: String? = "",
    @SerializedName("NTN") val NTN: String? = "" ,
    @SerializedName("CompleteNTN") val CompleteNTN: String? = "",
    @SerializedName("CNIC") val CNIC: String? =  "",
    @SerializedName("Email") val Email:  String? =  "",
    @SerializedName("Taxpayer_Type_ID") val Taxpayer_Type_ID: Int? = 0,
    @SerializedName("TaxPayer_Type_Description") val TaxPayer_Type_Description: String? = "",
    @SerializedName("Company_Type_ID") val Company_Type_ID: String? = "",
    @SerializedName("EI_Type_ID") val EI_Type_ID: String? = "",
    @SerializedName("Cell_No") val Cell_No: String? = "",
    @SerializedName("RegInc_No") val RegInc_No: String? = "",
    @SerializedName("Tax_OFFice_ID") var Tax_OFFice_ID: Int? = 0,
    @SerializedName("RegFor_IncomeTax") val RegFor_IncomeTax: Boolean,
    @SerializedName("RegFor_SalesTax") val RegFor_SalesTax: Boolean,
    @SerializedName("User_ID") val User_ID: String? = "",
    @SerializedName("Business_Name") val Business_Name: String? = "",
    @SerializedName("Address") val Address: String? = "",
    @SerializedName("STRN") val STRN: String? = "",
    var CNIC_NTN: String? = ""){
    constructor():this(0,"","","","","","",
        0,"","","","","",0,
        false,false,"","","","","")
}

data class TaxOffices(
    @SerializedName("Tax_Office_ID") val Tax_Office_ID: Int? = 0,
    @SerializedName("Title") val Title: String? = "",
    @SerializedName("Tax_Office_Category_ID") val Tax_Office_Category_ID: Int? = 0,
    @SerializedName("Tax_Office_Code") val Tax_Office_Code: Int? = 0)

data class Businesses (
    @SerializedName("Business_ID") val Business_ID : Int? = 0,
    @SerializedName("Name") val Name :  String? =  "",
    @SerializedName("STRN") val STRN :  String? =  "",
    @SerializedName("Address") val Address : String? = "",
    @SerializedName("CNIC") val CNIC : String? = "",
    @SerializedName("Source_Type_ID") val Source_Type_ID : Int? = 0,
    @SerializedName("Tax_Office_ID") val Tax_Office_ID : Int? = 0
)

data class Message(
    @SerializedName("IsSuccess") val IsSuccess: Int? = 0,
    @SerializedName("IsAuthenticated") val IsAuthenticated: Int? = 0,
    @SerializedName("Message") val Message: String? = "",
    @SerializedName("Status") val Status: Int? = 0,
    @SerializedName("Message_Detail") val message_Detail : String? = "",
    @SerializedName("client_hint") val client_hint : String? = "",
    @SerializedName("SMS_PINCODE") val SMS_PINCODE : String? = "",
    @SerializedName("EMAIL_PINCODE") val EMAIL_PINCODE : String? = "",
    @SerializedName("ID") val ID : String? = ""
)

data class DropDownModel(
    @SerializedName("ID") var ID: Int? = 0,
    @SerializedName("DESCRIPTION") var DESCRIPTION: String? = "" ,
    @SerializedName("Text") var Text: String? = "",
    @SerializedName("Value") var Value: Int? = 0,
    @SerializedName("Nature_Code") var Nature_Code: Int? = 0,
    @SerializedName("DISTRICT_CODE") var DISTRICT_CODE: Long? = 0,
    @SerializedName("DISTRICT") var DISTRICT: String? = "",
    @SerializedName("IMAGE_PATH") var IMAGE_PATH: String? = "",
    @SerializedName("MIN_FIELD_LENGTH") var MIN_FIELD_LENGTH: Int? = 0,
    @SerializedName("FIELD_LENGTH") var FIELD_LENGTH: Int? = 0,
    @SerializedName("IS_NUMERIC") var IS_NUMERIC: Int? = 0,
    var isSelected: Boolean? = false
){
    constructor():this(0,"","",0,0,0,"", "",0,0,0,false)
}