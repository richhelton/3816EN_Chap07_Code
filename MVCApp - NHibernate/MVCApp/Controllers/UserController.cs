
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using NLog;
using NServiceBus;
using MVCApp.DAL;
using MVCApp.Models;
using System.Xml;
using System.IO;
using MVCApp.Mapping;


namespace MVCApp.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/


        private static Logger logger = LogManager.GetCurrentClassLogger();


        /***
         * 
         * Will load the table from XML files
         * 
         * ****/
        public ActionResult MyPublisher()
        {
            List<MyPublisherExt> models = new List<MyPublisherExt>();
            using (var db = new nservicebusEntities())
            {
                var publishers = db.MyPublishers;
                foreach (var publisher in publishers)
                {
                    MyPublisherExt data = new MyPublisherExt();
                    data.publisher = publisher;
                    if (publisher.Body != null)
                        data.reader = System.Text.UTF8Encoding.UTF8.GetString(publisher.Body);
                    models.Add(data);
                }
            }
            return View(models);
        }


        public ActionResult Subscriber1()
        {
            List<Subscriber1Ext> models = new List<Subscriber1Ext>();
            using (var db = new nservicebusEntities())
            {
                var subscribers = db.Subscriber1;
                foreach (var subscriber in subscribers)
                {
                    Subscriber1Ext data = new Subscriber1Ext();
                    data.subscriber = subscriber;
                    if (subscriber.Body != null)
                        data.reader = System.Text.UTF8Encoding.UTF8.GetString(subscriber.Body);
                    models.Add(data);
                }
            }
            return View(models);
        }

        public ActionResult Subscriber2()
        {
            List<Subscriber2Ext> models = new List<Subscriber2Ext>();
            using (var db = new nservicebusEntities())
            {
                var subscribers = db.Subscriber2;
                foreach (var subscriber in subscribers)
                {
                    Subscriber2Ext data = new Subscriber2Ext();
                    data.subscriber = subscriber;
                    if (subscriber.Body != null)
                        data.reader = System.Text.UTF8Encoding.UTF8.GetString(subscriber.Body);
                    models.Add(data);
                }
            }
            return View(models);
        }

        public ActionResult Audit()
        {
            List<MVCApp.Models.AuditExt> models = new List<MVCApp.Models.AuditExt>();
            using (var session = NHibernateHelper.OpenSession())
            {

                var audits = session.QueryOver<AuditExt2>().List();
                foreach (var audit in audits)
                {
                    AuditExt data = new AuditExt();
                    data.audit = new DAL.audit();
                    data.audit.Headers = audit.Headers;
                    data.audit.Id = audit.Id;
                    data.audit.ReplyToAddress = audit.ReplyToAddress;
                    data.audit.Recoverable = audit.Recoverable;
                    data.audit.Expires = audit.Expires;
                    data.audit.RowVersion = audit.RowVersion;
                    if (audit.Body == null)
                    {
                        data.reader = " ";
                    }
                    else
                    {
                        data.reader = System.Text.UTF8Encoding.UTF8.GetString(audit.Body);
                    }
                    models.Add(data);
                }
            }
            return View(models);
        }

        public ActionResult Errors()
        {
            List<ErrorExt> models = new List<ErrorExt>();
            using (var db = new nservicebusEntities())
            {
                var errors = db.errors;
                foreach (var error in errors)
                {
                    ErrorExt data = new ErrorExt();
                    data.error = error;
                    if (error.Body != null)
                        data.reader = System.Text.UTF8Encoding.UTF8.GetString(error.Body);
                    models.Add(data);
                }
            }
            return View(models);
        }
        public ActionResult Subscription()
        {
            List<MVCApp.DAL.Subscription> models = new List<MVCApp.DAL.Subscription>();
            using (var db = new nservicebusEntities())
            {
                var subscriptions = db.Subscriptions;
                foreach (var subscription in subscriptions)
                {
                    models.Add(subscription);
                }
            }
            return View(models);
        }
    }
}
