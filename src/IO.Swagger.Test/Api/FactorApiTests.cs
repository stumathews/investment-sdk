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
    ///  Class for testing FactorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FactorApiTests
    {
        private FactorApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FactorApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FactorApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FactorApi
            //Assert.IsInstanceOfType(typeof(FactorApi), instance, "instance is a FactorApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvestmentInfluenceFactor entity = null;
            //instance.Create(entity);
            
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.Delete(id);
            
        }
        
        /// <summary>
        /// Test GenerateEntityInvestmentsGraphFor
        /// </summary>
        [Test]
        public void GenerateEntityInvestmentsGraphForTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? entityId = null;
            //instance.GenerateEntityInvestmentsGraphFor(entityId);
            
        }
        
        /// <summary>
        /// Test GenerateSharedGraphDataForAll
        /// </summary>
        [Test]
        public void GenerateSharedGraphDataForAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GenerateSharedGraphDataForAll();
            
        }
        
        /// <summary>
        /// Test GetAll
        /// </summary>
        [Test]
        public void GetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAll();
            //Assert.IsInstanceOf<List<InvestmentInfluenceFactor>> (response, "response is List<InvestmentInfluenceFactor>");
        }
        
        /// <summary>
        /// Test GetAllWithoutChildren
        /// </summary>
        [Test]
        public void GetAllWithoutChildrenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllWithoutChildren();
            //Assert.IsInstanceOf<List<InvestmentInfluenceFactor>> (response, "response is List<InvestmentInfluenceFactor>");
        }
        
        /// <summary>
        /// Test GetById
        /// </summary>
        [Test]
        public void GetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //instance.GetById(id);
            
        }
        
        /// <summary>
        /// Test Import
        /// </summary>
        [Test]
        public void ImportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<InvestmentInfluenceFactor> entities = null;
            //instance.Import(entities);
            
        }
        
        /// <summary>
        /// Test Patch
        /// </summary>
        [Test]
        public void PatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //List<Operation> patchDocument = null;
            //instance.Patch(id, patchDocument);
            
        }
        
        /// <summary>
        /// Test Replace
        /// </summary>
        [Test]
        public void ReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //InvestmentInfluenceFactor newItem = null;
            //instance.Replace(id, newItem);
            
        }
        
    }

}