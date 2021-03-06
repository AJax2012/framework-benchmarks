package com.springboot.benchmark.springbootbenchmark;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
@RestController
public class SpringBootBenchmarkApplication {

	public static void main(String[] args) {
		SpringApplication.run(SpringBootBenchmarkApplication.class, args);
	}

	@GetMapping("/hello")
	public String hello() {
		return "Hello Spring!";
	}
}
