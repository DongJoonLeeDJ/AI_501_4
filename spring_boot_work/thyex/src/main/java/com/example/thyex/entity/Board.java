package com.example.thyex.entity;

import com.example.thyex.dto.BoardFormDto;
import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;
import org.springframework.boot.context.properties.bind.DefaultValue;

import javax.persistence.*;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

@Entity
@Getter
@Setter
public class Board {

    @Id
    @Column(name = "board_id", nullable = false)
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String name;
    private String title;
    private String content;
    
    @Column(name="wdate", updatable = false)
    @CreationTimestamp
    private LocalDateTime wdate;

    @OneToMany(mappedBy = "board",
            cascade = CascadeType.ALL
            , orphanRemoval = true,
            fetch = FetchType.EAGER)
    List<BoardTail> boardTailList
            = new ArrayList<>();

//    lazy -> 원본글 select, board_table select...
//    select
//        board0_.board_id as board_id1_1_0_,
//        board0_.content as content2_1_0_,
//        board0_.name as name3_1_0_,
//        board0_.title as title4_1_0_,
//        board0_.wdate as wdate5_1_0_,
//        boardtaill1_.board_id as board_id5_2_1_,
//        boardtaill1_.boardtail_id as boardtai1_2_1_,
//        boardtaill1_.boardtail_id as boardtai1_2_2_,
//        boardtaill1_.board_id as board_id5_2_2_,
//        boardtaill1_.content as content2_2_2_,
//        boardtaill1_.name as name3_2_2_,
//        boardtaill1_.wdate as wdate4_2_2_
//            from board board0_
//    left outer join
//    board_tail boardtaill1_
//    on board0_.board_id=boardtaill1_.board_id
//            where
//    board0_.board_id=?

    public static Board createBoard(BoardFormDto boardFormDto) {
        Board board = new Board();
        board.setContent(boardFormDto.getContent());
        board.setName(boardFormDto.getName());
        board.setTitle(boardFormDto.getTitle());
        board.setWdate(LocalDateTime.now());
        return board;
    }
}
