package com.example.thyex.controller;

import com.example.thyex.entity.Todo;
import com.example.thyex.repository.TodoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.time.LocalDateTime;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@Controller
@RequestMapping("todo")
public class TodoController {

    @Autowired
    TodoRepository todoRepository;

    @GetMapping("selectall")
    public String selectall(Model model) {
        List<Todo> list = todoRepository.findAll();
        model.addAttribute("list",list);
        return "todo/selectall";
    }

    @PostMapping("insert")
    public String insert(@Valid Todo todo, BindingResult bindingResult){
        if(bindingResult.hasErrors()){
            return "redirect:selectall";
        }
        // id 는 설정을 안해도 자동으로..
        // wdate 날짜는 만들어서 넣어줘야..
        todo.setWdate(LocalDateTime.now());
        todoRepository.save(todo);

        return "redirect:selectall";
    }

    @DeleteMapping("delete")
    @ResponseBody
    public Map<String, Object> delete(String name, String content){
        System.out.println("name ="+name);
        System.out.println("content ="+content);
        Map<String,Object> map = new HashMap<>();
        map.put("code","0000");
//        return name+" asdf "+content;
        return map;
    }
}

