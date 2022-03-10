package com.example.thyex.dto;

import lombok.*;
import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.validator.constraints.Length;

import javax.persistence.Column;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotEmpty;
import java.time.LocalDateTime;

@Setter
@Getter
@AllArgsConstructor
@NoArgsConstructor
@ToString
public class BoardFormDto {
    private Long id;

    @NotEmpty(message = "필수입력값입니다.")
    @Length(min = 2, max = 8,message = "작성자의 길이는 2이상 8이하 이어야합니다.")
    private String name;

    @NotEmpty(message = "필수입력값입니다.")
    @Length(min = 2, max = 8,message = "글제목의 길이는 2이상 8이하 이어야합니다.")
    private String title;

    @NotEmpty(message = "필수입력값입니다.")
    @Length(min = 5, max = 100, message = "글제목의 길이는 5이상 100이하 이어야합니다.")
    private String content;

    private LocalDateTime wdate;

}
