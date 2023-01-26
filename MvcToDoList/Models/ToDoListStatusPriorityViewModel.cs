﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcToDoList.Models
{
    public class ToDoListStatusPriorityViewModel
    {
        public List<ToDoList>? ToDoLists { get; set; }    
        public SelectList? Statuses { get; set; } 
        public string? ToDoListStatus { get; set; }
        public string? SearchString { get; set; }
    }
}
