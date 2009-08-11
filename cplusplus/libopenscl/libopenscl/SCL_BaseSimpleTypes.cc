// Copyright (C) 2005-2008 Code Synthesis Tools CC
//
// This program was generated by CodeSynthesis XSD, an XML Schema to
// C++ data binding compiler.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License version 2 as
// published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA
//
// In addition, as a special exception, Code Synthesis Tools CC gives
// permission to link this program with the Xerces-C++ library (or with
// modified versions of Xerces-C++ that use the same license as Xerces-C++),
// and distribute linked combinations including the two. You must obey
// the GNU General Public License version 2 in all respects for all of
// the code used other than Xerces-C++. If you modify this copy of the
// program, you may extend this exception to your version of the program,
// but you are not obligated to do so. If you do not wish to do so, delete
// this exception statement from your version.
//
// Furthermore, Code Synthesis Tools CC makes a special exception for
// the Free/Libre and Open Source Software (FLOSS) which is described
// in the accompanying FLOSSE file.
//

// Begin prologue.
//
//
// End prologue.

#include <xsd/cxx/pre.hxx>

#include "SCL_BaseSimpleTypes.h"

namespace IEC61850
{
  namespace SCL
  {
    // tRef
    // 


    // tAnyName
    // 


    // tName
    // 


    // tRestrName
    // 


    // tRestrLdName
    // 


    // tRestrName1stU
    // 


    // tRestrName1stL
    // 


    // tPAddr
    // 
  }
}

#include <xsd/cxx/xml/dom/parsing-source.hxx>

namespace IEC61850
{
  namespace SCL
  {
    // tRef
    //

    tRef::
    tRef ()
    : ::xml_schema::normalized_string ()
    {
    }

    tRef::
    tRef (const char* _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tRef::
    tRef (const ::std::string& _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tRef::
    tRef (const ::xml_schema::normalized_string& _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tRef::
    tRef (const tRef& x,
          ::xml_schema::flags f,
          ::xml_schema::container* c)
    : ::xml_schema::normalized_string (x, f, c)
    {
    }

    tRef::
    tRef (const ::xercesc::DOMElement& e,
          ::xml_schema::flags f,
          ::xml_schema::container* c)
    : ::xml_schema::normalized_string (e, f, c)
    {
    }

    tRef::
    tRef (const ::xercesc::DOMAttr& a,
          ::xml_schema::flags f,
          ::xml_schema::container* c)
    : ::xml_schema::normalized_string (a, f, c)
    {
    }

    tRef::
    tRef (const ::std::string& s,
          const ::xercesc::DOMElement* e,
          ::xml_schema::flags f,
          ::xml_schema::container* c)
    : ::xml_schema::normalized_string (s, e, f, c)
    {
    }

    tRef* tRef::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tRef (*this, f, c);
    }

    tRef::
    ~tRef ()
    {
    }

    // tAnyName
    //

    tAnyName::
    tAnyName ()
    : ::xml_schema::normalized_string ()
    {
    }

    tAnyName::
    tAnyName (const char* _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tAnyName::
    tAnyName (const ::std::string& _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tAnyName::
    tAnyName (const ::xml_schema::normalized_string& _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tAnyName::
    tAnyName (const tAnyName& x,
              ::xml_schema::flags f,
              ::xml_schema::container* c)
    : ::xml_schema::normalized_string (x, f, c)
    {
    }

    tAnyName::
    tAnyName (const ::xercesc::DOMElement& e,
              ::xml_schema::flags f,
              ::xml_schema::container* c)
    : ::xml_schema::normalized_string (e, f, c)
    {
    }

    tAnyName::
    tAnyName (const ::xercesc::DOMAttr& a,
              ::xml_schema::flags f,
              ::xml_schema::container* c)
    : ::xml_schema::normalized_string (a, f, c)
    {
    }

    tAnyName::
    tAnyName (const ::std::string& s,
              const ::xercesc::DOMElement* e,
              ::xml_schema::flags f,
              ::xml_schema::container* c)
    : ::xml_schema::normalized_string (s, e, f, c)
    {
    }

    tAnyName* tAnyName::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tAnyName (*this, f, c);
    }

    tAnyName::
    ~tAnyName ()
    {
    }

    // tName
    //

    tName::
    tName ()
    : ::IEC61850::SCL::tAnyName ()
    {
    }

    tName::
    tName (const char* _xsd_normalized_string_base)
    : ::IEC61850::SCL::tAnyName (_xsd_normalized_string_base)
    {
    }

    tName::
    tName (const ::std::string& _xsd_normalized_string_base)
    : ::IEC61850::SCL::tAnyName (_xsd_normalized_string_base)
    {
    }

    tName::
    tName (const ::xml_schema::normalized_string& _xsd_normalized_string_base)
    : ::IEC61850::SCL::tAnyName (_xsd_normalized_string_base)
    {
    }

    tName::
    tName (const tName& x,
           ::xml_schema::flags f,
           ::xml_schema::container* c)
    : ::IEC61850::SCL::tAnyName (x, f, c)
    {
    }

    tName::
    tName (const ::xercesc::DOMElement& e,
           ::xml_schema::flags f,
           ::xml_schema::container* c)
    : ::IEC61850::SCL::tAnyName (e, f, c)
    {
    }

    tName::
    tName (const ::xercesc::DOMAttr& a,
           ::xml_schema::flags f,
           ::xml_schema::container* c)
    : ::IEC61850::SCL::tAnyName (a, f, c)
    {
    }

    tName::
    tName (const ::std::string& s,
           const ::xercesc::DOMElement* e,
           ::xml_schema::flags f,
           ::xml_schema::container* c)
    : ::IEC61850::SCL::tAnyName (s, e, f, c)
    {
    }

    tName* tName::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tName (*this, f, c);
    }

    tName::
    ~tName ()
    {
    }

    // tRestrName
    //

    tRestrName::
    tRestrName (const char* _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName::
    tRestrName (const ::std::string& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName::
    tRestrName (const ::xml_schema::name& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName::
    tRestrName (const tRestrName& x,
                ::xml_schema::flags f,
                ::xml_schema::container* c)
    : ::xml_schema::name (x, f, c)
    {
    }

    tRestrName::
    tRestrName (const ::xercesc::DOMElement& e,
                ::xml_schema::flags f,
                ::xml_schema::container* c)
    : ::xml_schema::name (e, f, c)
    {
    }

    tRestrName::
    tRestrName (const ::xercesc::DOMAttr& a,
                ::xml_schema::flags f,
                ::xml_schema::container* c)
    : ::xml_schema::name (a, f, c)
    {
    }

    tRestrName::
    tRestrName (const ::std::string& s,
                const ::xercesc::DOMElement* e,
                ::xml_schema::flags f,
                ::xml_schema::container* c)
    : ::xml_schema::name (s, e, f, c)
    {
    }

    tRestrName* tRestrName::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tRestrName (*this, f, c);
    }

    tRestrName::
    ~tRestrName ()
    {
    }

    // tRestrLdName
    //

    tRestrLdName::
    tRestrLdName (const char* _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrLdName::
    tRestrLdName (const ::std::string& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrLdName::
    tRestrLdName (const ::xml_schema::name& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrLdName::
    tRestrLdName (const tRestrLdName& x,
                  ::xml_schema::flags f,
                  ::xml_schema::container* c)
    : ::xml_schema::name (x, f, c)
    {
    }

    tRestrLdName::
    tRestrLdName (const ::xercesc::DOMElement& e,
                  ::xml_schema::flags f,
                  ::xml_schema::container* c)
    : ::xml_schema::name (e, f, c)
    {
    }

    tRestrLdName::
    tRestrLdName (const ::xercesc::DOMAttr& a,
                  ::xml_schema::flags f,
                  ::xml_schema::container* c)
    : ::xml_schema::name (a, f, c)
    {
    }

    tRestrLdName::
    tRestrLdName (const ::std::string& s,
                  const ::xercesc::DOMElement* e,
                  ::xml_schema::flags f,
                  ::xml_schema::container* c)
    : ::xml_schema::name (s, e, f, c)
    {
    }

    tRestrLdName* tRestrLdName::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tRestrLdName (*this, f, c);
    }

    tRestrLdName::
    ~tRestrLdName ()
    {
    }

    // tRestrName1stU
    //

    tRestrName1stU::
    tRestrName1stU (const char* _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName1stU::
    tRestrName1stU (const ::std::string& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName1stU::
    tRestrName1stU (const ::xml_schema::name& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName1stU::
    tRestrName1stU (const tRestrName1stU& x,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (x, f, c)
    {
    }

    tRestrName1stU::
    tRestrName1stU (const ::xercesc::DOMElement& e,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (e, f, c)
    {
    }

    tRestrName1stU::
    tRestrName1stU (const ::xercesc::DOMAttr& a,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (a, f, c)
    {
    }

    tRestrName1stU::
    tRestrName1stU (const ::std::string& s,
                    const ::xercesc::DOMElement* e,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (s, e, f, c)
    {
    }

    tRestrName1stU* tRestrName1stU::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tRestrName1stU (*this, f, c);
    }

    tRestrName1stU::
    ~tRestrName1stU ()
    {
    }

    // tRestrName1stL
    //

    tRestrName1stL::
    tRestrName1stL (const char* _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName1stL::
    tRestrName1stL (const ::std::string& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName1stL::
    tRestrName1stL (const ::xml_schema::name& _xsd_name_base)
    : ::xml_schema::name (_xsd_name_base)
    {
    }

    tRestrName1stL::
    tRestrName1stL (const tRestrName1stL& x,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (x, f, c)
    {
    }

    tRestrName1stL::
    tRestrName1stL (const ::xercesc::DOMElement& e,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (e, f, c)
    {
    }

    tRestrName1stL::
    tRestrName1stL (const ::xercesc::DOMAttr& a,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (a, f, c)
    {
    }

    tRestrName1stL::
    tRestrName1stL (const ::std::string& s,
                    const ::xercesc::DOMElement* e,
                    ::xml_schema::flags f,
                    ::xml_schema::container* c)
    : ::xml_schema::name (s, e, f, c)
    {
    }

    tRestrName1stL* tRestrName1stL::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tRestrName1stL (*this, f, c);
    }

    tRestrName1stL::
    ~tRestrName1stL ()
    {
    }

    // tPAddr
    //

    tPAddr::
    tPAddr ()
    : ::xml_schema::normalized_string ()
    {
    }

    tPAddr::
    tPAddr (const char* _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tPAddr::
    tPAddr (const ::std::string& _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tPAddr::
    tPAddr (const ::xml_schema::normalized_string& _xsd_normalized_string_base)
    : ::xml_schema::normalized_string (_xsd_normalized_string_base)
    {
    }

    tPAddr::
    tPAddr (const tPAddr& x,
            ::xml_schema::flags f,
            ::xml_schema::container* c)
    : ::xml_schema::normalized_string (x, f, c)
    {
    }

    tPAddr::
    tPAddr (const ::xercesc::DOMElement& e,
            ::xml_schema::flags f,
            ::xml_schema::container* c)
    : ::xml_schema::normalized_string (e, f, c)
    {
    }

    tPAddr::
    tPAddr (const ::xercesc::DOMAttr& a,
            ::xml_schema::flags f,
            ::xml_schema::container* c)
    : ::xml_schema::normalized_string (a, f, c)
    {
    }

    tPAddr::
    tPAddr (const ::std::string& s,
            const ::xercesc::DOMElement* e,
            ::xml_schema::flags f,
            ::xml_schema::container* c)
    : ::xml_schema::normalized_string (s, e, f, c)
    {
    }

    tPAddr* tPAddr::
    _clone (::xml_schema::flags f,
            ::xml_schema::container* c) const
    {
      return new class tPAddr (*this, f, c);
    }

    tPAddr::
    ~tPAddr ()
    {
    }
  }
}

#include <istream>
#include <xsd/cxx/xml/sax/std-input-source.hxx>
#include <xsd/cxx/tree/error-handler.hxx>

namespace IEC61850
{
  namespace SCL
  {
  }
}

#include <ostream>
#include <xsd/cxx/xml/dom/serialization-source.hxx>
#include <xsd/cxx/tree/error-handler.hxx>

namespace IEC61850
{
  namespace SCL
  {
    void
    operator<< (::xercesc::DOMElement& e, const tRef& i)
    {
      e << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tRef& i)
    {
      a << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tRef& i)
    {
      l << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tAnyName& i)
    {
      e << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tAnyName& i)
    {
      a << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tAnyName& i)
    {
      l << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tName& i)
    {
      e << static_cast< const ::IEC61850::SCL::tAnyName& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tName& i)
    {
      a << static_cast< const ::IEC61850::SCL::tAnyName& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tName& i)
    {
      l << static_cast< const ::IEC61850::SCL::tAnyName& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tRestrName& i)
    {
      e << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tRestrName& i)
    {
      a << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tRestrName& i)
    {
      l << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tRestrLdName& i)
    {
      e << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tRestrLdName& i)
    {
      a << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tRestrLdName& i)
    {
      l << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tRestrName1stU& i)
    {
      e << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tRestrName1stU& i)
    {
      a << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tRestrName1stU& i)
    {
      l << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tRestrName1stL& i)
    {
      e << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tRestrName1stL& i)
    {
      a << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tRestrName1stL& i)
    {
      l << static_cast< const ::xml_schema::name& > (i);
    }

    void
    operator<< (::xercesc::DOMElement& e, const tPAddr& i)
    {
      e << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xercesc::DOMAttr& a,const tPAddr& i)
    {
      a << static_cast< const ::xml_schema::normalized_string& > (i);
    }

    void
    operator<< (::xml_schema::list_stream& l,
                const tPAddr& i)
    {
      l << static_cast< const ::xml_schema::normalized_string& > (i);
    }
  }
}

#include <xsd/cxx/post.hxx>

// Begin epilogue.
//
//
// End epilogue.

