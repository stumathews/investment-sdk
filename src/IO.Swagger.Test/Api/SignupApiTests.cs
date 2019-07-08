/* 
 * Core Investment Tracker API
 *
 * Investment tracker is a platform that allows you to track aspects that affect your investments
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SignupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SignupApiTests
    {
        private SignupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SignupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SignupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SignupApi
            //Assert.IsInstanceOfType(typeof(SignupApi), instance, "instance is a SignupApi");
        }

        
        /// <summary>
        /// Test Signup
        /// </summary>
        [Test]
        public void SignupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SignupDetails signupDetails = null;
            //instance.Signup(signupDetails);
            
        }
        
    }

}