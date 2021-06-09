package com.example.mvvm.interfaces

interface LoginResultCallBacks {
    fun onSuccess(message:String)
    fun onError(message: String)
}