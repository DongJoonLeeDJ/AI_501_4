package com.example.thyex.study;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class AAController {

    // Controller
    // -> main -> main.html
    // GetMapping("main") .... return "main"

    // RestController
    // -> aa -> aa
    // GetMapping("aa") ....return "aa"

    @Autowired
    AARepository aaRepository;

    @GetMapping(value = "aa")
    public String select(){
        List<AA> list = aaRepository.findAll();
        System.out.println(list);
        return list.toString();
    }
}
