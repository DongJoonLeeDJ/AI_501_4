package com.example.thyex.controller;

import com.example.thyex.dto.BoardFormDto;
import com.example.thyex.dto.BoardTailFormDto;
import com.example.thyex.entity.Board;
import com.example.thyex.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.validation.Valid;
import java.util.List;

@RequestMapping("board")
@Controller
public class BoardController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("selectall")
    public String selectAll(Model model){
        List<Board> list = boardRepository.findAll();
        model.addAttribute("list",list);
        return "board/selectall";
    }

    @GetMapping("view")
    public String view(Model model,long id){
        Board board = boardRepository.findById(id).orElse(new Board());
        System.out.println(board);
        model.addAttribute("board",board);
        model.addAttribute("boardTailFormDto",new BoardTailFormDto());
        return "board/view";
    }

    @GetMapping("insert")
    public String insert(Model model){
        model.addAttribute("boardFormDto",new BoardFormDto());
        return "board/insert";
    }

    @PostMapping("insert")
    public String insert(@Valid BoardFormDto boardFormDto,
                         BindingResult bindingResult,
                         Model model){
        if( bindingResult.hasErrors() ){
            return "board/insert";
        }
        Board board = Board.createBoard(boardFormDto);
        boardRepository.save(board);

        return "redirect:selectall";
    }

}
