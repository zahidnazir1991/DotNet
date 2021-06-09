package com.example.mvvm.view

import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.databinding.DataBindingUtil
import androidx.lifecycle.Observer
import androidx.lifecycle.ViewModelProviders
import com.example.mvvm.R
import com.example.mvvm.interfaces.LoginResultCallBacks
import com.example.mvvm.databinding.ActivityLoginBinding
import com.example.mvvm.viewmodel.UserViewModel
import com.example.mvvm.viewmodel.factory.UserViewModelFactory


class LoginActivity : AppCompatActivity(), LoginResultCallBacks {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        val binding: ActivityLoginBinding = DataBindingUtil.setContentView(this, R.layout.activity_login)

        val userViewModel = ViewModelProviders.of(this,
            UserViewModelFactory(this)).get(UserViewModel::class.java)
        binding.userViewModel = userViewModel

      /*  userViewModel.showMessage.observe(this, Observer {
            it.getContentIfNotHandled()?.let { // Only proceed if the event has never been handled
                Toast.makeText(this, it, Toast.LENGTH_SHORT).show()
            }
        })*/

    }

    override fun onSuccess(message: String) {
        Toast.makeText(this, message, Toast.LENGTH_SHORT).show()
    }

    override fun onError(message: String) {
        Toast.makeText(this, message, Toast.LENGTH_SHORT).show()
    }


}