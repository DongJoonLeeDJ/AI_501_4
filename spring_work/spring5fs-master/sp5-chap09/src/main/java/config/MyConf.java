package config;

import java.io.IOException;

import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.tomcat.jdbc.pool.DataSource;
import org.mybatis.spring.SqlSessionFactoryBean;
import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.io.support.PathMatchingResourcePatternResolver;

import mybeans.AA;

@Configuration
@ComponentScan(basePackages = {"chap09.member","chap09.todo"})
public class MyConf {

	@Bean(destroyMethod = "close")
	public DataSource dataSource() {
		DataSource ds = new DataSource();
		ds.setDriverClassName("com.mysql.cj.jdbc.Driver");
		ds.setUrl("jdbc:mysql://localhost/aa?characterEncoding=utf8");
		ds.setUsername("root");
		ds.setPassword("1234");
		ds.setInitialSize(2);
		ds.setMaxActive(5);
		ds.setTestWhileIdle(true);
		ds.setMinEvictableIdleTimeMillis(60000 * 3);
		ds.setTimeBetweenEvictionRunsMillis(10 * 1000);
		return ds;
	}
	/*
	 * pom.xml 
	 * datasource.jar
	 * 1.
	 * mybatis.jar
	 * mybatis-spring.jar
	 * 
	 * 2.
	 * SqlSessionFactoryBean 객체 주입
	 * SqlSessionTemplate 객체 주입
	 * 
	 * 3. Mapper.xml 작성
	 * 4. sql 구문작성.
	 */
	@Bean
	public SqlSessionFactory sqlsessionfactorybean() throws Exception {
		SqlSessionFactoryBean ss = new SqlSessionFactoryBean();
		ss.setMapperLocations(
				new PathMatchingResourcePatternResolver()
				.getResources("classpath*:*/*/*mapper.xml"));
		ss.setDataSource(dataSource());
		return ss.getObject();
	}

	@Bean
	public SqlSessionTemplate sqlsessiontemplate() throws Exception {
		SqlSessionFactory ssf = sqlsessionfactorybean();
		SqlSessionTemplate sst = new SqlSessionTemplate(ssf);
		return sst;
	}
	
	
	
}
