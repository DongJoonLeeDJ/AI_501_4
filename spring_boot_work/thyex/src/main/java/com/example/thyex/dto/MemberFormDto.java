package com.example.thyex.dto;

import lombok.*;
import org.hibernate.validator.constraints.Length;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotEmpty;

@Getter
@Setter
@ToString
@AllArgsConstructor
@RequiredArgsConstructor
public class MemberFormDto {

    @NotEmpty(message = "필수 입력값입니다.")
    @Email(message = "이메일 형식어이야 합니다.")
    private String email;

    @NotEmpty(message = "필수 입력값입니다.")
    @Length(min = 4, max = 8,message = "비밀번호의 길이는 4이상 8이하 이어야합니다.")
    private String pwd;
}
