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

    @GetMapping(value = "aaselect")
    public String select(){
        //List<AA> list = aaRepository.findAllById(Arrays.asList(1L,2L,3L));
        List<AA> list = aaRepository.findAll();
//        AA aa = aaRepository.findById(1L).orElse(new AA());
        System.out.println(list);
        return list.toString();
    }

    @GetMapping(value = "aainsert")
    public String insert(){
        aaRepository.save(new AA(11,"bbb"));
        return "aa insert";
    }

    @GetMapping(value = "aaupdate")
    public String update(){
        aaRepository.save(new AA(1L,22,"ccc"));
        return "aa update";
    }

    @GetMapping(value = "aadelete")
    public String delete(){
        aaRepository.delete(new AA(1L,22,"ccc"));
        return "aa delete";
    }

    @GetMapping(value = "aadeleteall")
    public String deleteall(){
        aaRepository.deleteAll();
        return "aa deleteAll";
    }
}
