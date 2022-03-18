package com.example.thyex.config;

import com.example.thyex.entity.Member;
import com.example.thyex.repository.MemberRepository;
import com.example.thyex.service.MemberService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;

import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.util.matcher.AntPathRequestMatcher;
import org.springframework.security.config.annotation.web.builders.WebSecurity;

@Configuration
@EnableWebSecurity
public class SecurityConfig extends WebSecurityConfigurerAdapter {

    @Autowired
    MemberRepository memberRepository;

    @Override
    protected void configure(HttpSecurity http) throws Exception {
        http.formLogin()
                    .loginPage("/member/login")
                    .defaultSuccessUrl("/main")
                    .usernameParameter("email")
                    .failureUrl("/member/login?error")
                .and()
                    .logout()
                    .logoutRequestMatcher(new AntPathRequestMatcher("/member/logout"))
                    .logoutSuccessUrl("/main")
        ;


//        http.authorizeRequests().anyRequest().permitAll();
//        http.authorizeRequests().anyRequest().permitAll();


        http.authorizeRequests()
                .mvcMatchers("/",
                            "/main/**",
                            "/board/**",
                            "/boardtail/**",
                            "/member/login",
                            "/member/login?error",
                            "/api/**"
//                        , "/img/**"
                        ).permitAll()
                .mvcMatchers("/admin").hasRole("ADMIN")
                .anyRequest().authenticated()
        ;

//        http.exceptionHandling()
//                .authenticationEntryPoint(new CustomAuthenticationEntryPoint())
//        ;

    }

    @Bean
    public PasswordEncoder passwordEncoder() {
        return new BCryptPasswordEncoder();
    }

    @Override
    protected void configure(AuthenticationManagerBuilder auth) throws Exception {
        auth.userDetailsService( (email)->{
                    Member member = memberRepository.findByEmail(email);

                    if( member == null)
                        throw new UsernameNotFoundException(email);

                    return User.builder()
                            .username(member.getEmail())
                            .password(member.getPwd())
                            .roles("USER")
                            .build();
                })
                .passwordEncoder(passwordEncoder());
    }

    @Override
    public void configure(WebSecurity web) throws Exception {
        web.ignoring().antMatchers("/css/**", "/js/**", "/img/**");
    }

}
