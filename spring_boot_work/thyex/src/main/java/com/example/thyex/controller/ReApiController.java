package com.example.thyex.controller;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api")
public class ReApiController {

    @GetMapping("select")
    public String apiselect(){
        return "select";
    }

    @PutMapping("insert")
    public String apiinsert(){
        return "insert";
    }
}
