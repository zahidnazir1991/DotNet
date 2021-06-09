package com.example.mvvm.viewmodel.factory

import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import com.example.mvvm.interfaces.LoginResultCallBacks
import com.example.mvvm.viewmodel.UserViewModel

class UserViewModelFactory(private val mmLoginResultCallBacks: LoginResultCallBacks) :
    ViewModelProvider.NewInstanceFactory() {

    override fun <T : ViewModel?> create(modelClass: Class<T>): T {
        return UserViewModel(mmLoginResultCallBacks) as T
    }

}