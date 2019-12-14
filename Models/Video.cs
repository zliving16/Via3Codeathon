using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

public class Videos{
    [Key]
    public int VideoId{get;set;}
    [Required]
    public string Url{get;set;}
    [Required]
    [MaxLength(255)]
    public string Desc{get;set;}
    [Required]
    [MaxLength(55)]
    public string ProgramLang{get;set;}


}