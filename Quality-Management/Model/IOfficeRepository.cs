﻿namespace Quality_Management.Model;

public interface IOfficeRepository
{
    public Task<IList<Office>> FindAll();
}