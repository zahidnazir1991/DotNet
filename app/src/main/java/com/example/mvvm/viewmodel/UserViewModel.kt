package com.example.mvvm.viewmodel

import android.text.Editable
import android.text.TextWatcher
import android.view.View
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.mvvm.Event
import com.example.mvvm.interfaces.LoginResultCallBacks
import com.example.mvvm.model.UserRequestModel


class UserViewModel(private val mLoginResultCallBacks: LoginResultCallBacks) : ViewModel() {

    var loginID = MutableLiveData<String>()
    var loginPassword = MutableLiveData<String>()
    var welcome = MutableLiveData<String>()
    var progressbarVisibility: MutableLiveData<Int>? = null
    var userRequestModel =  UserRequestModel()

    val _showMessage = MutableLiveData<Event<String>>()
    val showMessage: LiveData<Event<String>>
        get() = _showMessage

    init {
        welcome.value = userRequestModel.getWelcomeMessage()
        userRequestModel.setUserLoginID("")
        userRequestModel.setUserLoginPassword("")
    }

    //Login id textwatcher
    val LoginIDTextWatcher: TextWatcher
        get() = object : TextWatcher {
            override fun afterTextChanged(string: Editable?) {
                userRequestModel.setUserLoginID(string.toString())
            }

            override fun beforeTextChanged(s: CharSequence?, start: Int, count: Int, after: Int) {}
            override fun onTextChanged(s: CharSequence?, start: Int, before: Int, count: Int) {}

        }

    //loginPassword text watcher
    val LoginPasswordTextWatcher: TextWatcher
        get() = object : TextWatcher {
            override fun afterTextChanged(string: Editable?) {
                userRequestModel.setUserLoginPassword(string.toString())
            }

            override fun beforeTextChanged(s: CharSequence?, start: Int, count: Int, after: Int) {}
            override fun onTextChanged(s: CharSequence?, start: Int, before: Int, count: Int) {}

        }


    fun getProgressbarStatus(): MutableLiveData<Int> {
        if (progressbarVisibility == null) {
            progressbarVisibility = MutableLiveData()
            progressbarVisibility!!.value = View.GONE
        }
        return progressbarVisibility!!
    }

    fun setToastMessage(message: String) {
        _showMessage.value = Event(message)
    }

    fun onLoginClick() {

        //login code 0 : Missing Login ID
        //login code 1 : Missing Login Password
        val loginCode = userRequestModel.isDataValid()

        if (loginCode < 0) {

            userRequestModel.setUserLoginID(loginID.value.toString())
            userRequestModel.setUserLoginPassword(loginPassword.value.toString())

        } else {
            when(loginCode){
                0 -> mLoginResultCallBacks.onError("Invalid Login ID")
                1 -> mLoginResultCallBacks.onError("Invalid Login Password")
            }
        }


    }

}
