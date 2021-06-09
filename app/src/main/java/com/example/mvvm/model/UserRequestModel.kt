package com.example.mvvm.model

import android.text.TextUtils
import android.util.Patterns
import java.io.Serializable


data class UserRequestModel(
    var outputtype: Int? = 0,
    var Service_ID: Int? = 0,
    var Password: String? = "",
    var Login_ID: String? = "",
    var Login_Password: String? = ""
): Serializable {
    constructor() : this(
        5,
        7,
        "123456",
        "0",
        "0"
    )

    fun setUserLoginID(loginId: String): UserRequestModel {
        Login_ID = loginId
        return this
    }

    fun setUserLoginPassword(loginPass: String): UserRequestModel {
        Login_Password = loginPass
        return this
    }

    fun getWelcomeMessage() : String{
        return "Welcome "+ this.Login_ID.toString()
    }

    fun isDataValid(): Int{
        if (TextUtils.isEmpty(Login_ID))
            return  0
        else if (TextUtils.isEmpty(Login_Password))
            return  1
        else
            return -1
    }
}