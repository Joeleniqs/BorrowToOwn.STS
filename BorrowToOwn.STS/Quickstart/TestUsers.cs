// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace BorrowToOwn.STS
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = Guid.NewGuid().ToString(), Username = "joeleniqs", Password = "Pasxword1!", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Joel Eniqs"),
                    new Claim(JwtClaimTypes.GivenName, "Joel"),
                    new Claim(JwtClaimTypes.FamilyName, "Eniqs"),
                    new Claim(JwtClaimTypes.Email, "joeleniqs@gmail.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "https://google.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            }
        };
    }
}