package com.example.mvvm.network

import com.example.mvvm.data.LoginResponseModel
import com.example.mvvm.model.UserRequestModel
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.Body
import retrofit2.http.Headers
import retrofit2.http.POST

interface ApiInterface {

    @Headers("Content-Type: application/json")
    @POST("api/OVS/AuthenticatePost")
    suspend fun userLogin(
        @Body loginModel: UserRequestModel
    ) : LoginResponseModel

    // this below fuctions used for retrofit calling functions
    companion object{
        operator fun invoke(): ApiInterface
        {
            return Retrofit.Builder()
                .baseUrl("http://72.255.56.84:8090/")
                .addConverterFactory(GsonConverterFactory.create())
                .build()
                .create(ApiInterface::class.java)
        }
    }

}