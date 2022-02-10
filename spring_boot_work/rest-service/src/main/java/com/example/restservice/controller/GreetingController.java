package com.example.restservice.controller;


import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GreetingController {

    @GetMapping("restindex")
    public String restindex(){
        return "restindex";
    }
}
