package com.example.thyex.controller;

import com.example.thyex.entity.Todo;
import com.example.thyex.repository.TodoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.time.LocalDateTime;
import java.util.List;

@Controller
@RequestMapping("todo")
public class TodoController {

    @Autowired
    TodoRepository todoRepository;

    @GetMapping("selectall")
    public String selectall(Model model) {
        todoRepository.save(new Todo(0L,"할일1", LocalDateTime.now()));
        todoRepository.save(new Todo(1L,"할일2", LocalDateTime.now()));
        List<Todo> list = todoRepository.findAll();
        System.out.println(list);
        model.addAttribute("list",list);
        return "todo/selectall";
    }
}
