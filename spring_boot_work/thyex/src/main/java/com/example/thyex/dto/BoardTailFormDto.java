package com.example.thyex.dto;

import com.example.thyex.entity.Board;
import lombok.*;
import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.validator.constraints.Length;

import javax.persistence.Column;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.validation.constraints.NotEmpty;
import java.time.LocalDateTime;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@ToString
public class BoardTailFormDto {
    private Long id;

    @NotEmpty(message = "필수 입력값입니다.")
    @Length(min=2,max=14,message = "이름의 길이는 2이상14이하여야합니다.")
    private String name;

    @NotEmpty(message = "필수 입력값입니다.")
    @Length(min=5,max=100,message = "내용의 길이는 2이상14이하여야합니다.")
    private String content;

    private LocalDateTime wdate;
    private Long board_id;
}
