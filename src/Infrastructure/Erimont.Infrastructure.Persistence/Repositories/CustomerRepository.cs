﻿using Microsoft.EntityFrameworkCore;
using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Domain.Customers;
using Erimont.Infrastructure.Persistence.Records;
using System.Threading.Tasks;

namespace Erimont.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<Customer> FindAsync(CustomerIdentity customerId)
        {
            var customerRecord = await Context.Customers.AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == customerId);

            if (customerRecord == null)
            {
                return null;
            }

            return GetCustomer(customerRecord);
        }

        public async Task AddAsync(Customer customer)
        {
            var customerRecord = CreateCustomerRecord(customer);
            Context.Customers.Add(customerRecord);
            await Context.SaveChangesAsync();
        }

        public async Task RemoveAsync(CustomerIdentity customerId)
        {
            var customerRecord = await Context.Customers
                .FirstOrDefaultAsync(e => e.Id == customerId);

            Context.Remove(customerRecord);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            var customerRecord = await Context.Customers
                .FirstOrDefaultAsync(e => e.Id == customer.Id);

            UpdateCustomerRecord(customerRecord, customer);

            try
            {
                Context.Customers.Update(customerRecord);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ConcurrentUpdateException(ex.Message, ex);
            }
        }

        private CustomerRecord CreateCustomerRecord(Customer customer)
        {
            return new CustomerRecord
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
            };
        }

        private void UpdateCustomerRecord(CustomerRecord customerRecord, Customer customer)
        {
            customerRecord.Id = customer.Id;
            customerRecord.FirstName = customer.FirstName;
            customerRecord.LastName = customer.LastName;
        }

        private Customer GetCustomer(CustomerRecord customerRecord)
        {
            var identity = new CustomerIdentity(customerRecord.Id);
            var firstName = customerRecord.FirstName;
            var lastName = customerRecord.LastName;

            return new Customer(identity, firstName, lastName);
        }
    }
}